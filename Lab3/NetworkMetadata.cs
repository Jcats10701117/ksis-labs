using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class NetworkMetadata
    {
        public string ShowAllNetworkInterfaces()
        {
            StringBuilder result = new StringBuilder();


            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                result.AppendLine(string.Empty.PadLeft(50, '='));
                result.AppendLine($"имя сетевого адаптера: {adapter.Name}");
                result.AppendLine($"тип сетевого интерфейча: {adapter.NetworkInterfaceType}");
                result.AppendLine($"описание интерфейса: {adapter.Description}");
                result.AppendLine($"состояние четевого подключения:  {adapter.OperationalStatus}");

                //ПОЛУЧЕНИЕ  и вывод физического адреса
                PhysicalAddress physicaladress = adapter.GetPhysicalAddress();
                byte[] bytes = physicaladress.GetAddressBytes();
                result.Append("физический адрес: ");
                for (int i = 0; i < bytes.Length; i++)
                {
                    result.Append(bytes[i].ToString("X2"));
                    if (i != bytes.Length - 1)
                    {
                        result.Append("-");
                    }
                }


                result.AppendLine("");
                result.AppendLine($"Размер физического адреса: {bytes.Length} байт");

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();

                UnicastIPAddressInformationCollection unicastCollection = adapterProperties.UnicastAddresses;


                if (unicastCollection.Count > 0)
                {
                    foreach (UnicastIPAddressInformation unicastAddr in unicastCollection)
                    {
                        result.AppendLine($"Длина сетевого префикса: {unicastAddr.PrefixLength}");
                        if (unicastAddr.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            result.AppendLine($"IPv4 адрес: {unicastAddr.Address}");
                        }
                        if (unicastAddr.Address.AddressFamily == AddressFamily.InterNetworkV6)
                        {
                            result.AppendLine($"Ipv6 адресс: {unicastAddr.Address}");
                        }
                    }
                }

                result.AppendLine("");
            }

            result.AppendLine("");

            return result.ToString()
                ;
        }
        public string GetIpFromDns(string dns)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Adresses of {dns}:");



            foreach (var ip in Dns.GetHostAddresses(dns))
            {
                switch (ip.AddressFamily)
                {
                    case AddressFamily.InterNetwork:
                        result.AppendLine($"IpV4: {ip}");
                        break;
                    case AddressFamily.InterNetworkV6:
                        result.AppendLine($"IpV6: {ip}");
                        break;
                }
            }

            var host = Dns.GetHostByName(dns);

            result.AppendLine("Addresses of the dns: ");

            host.AddressList.ToList().ForEach(address => result.AppendLine($"{address.ToString()}"));

            result.Append("Aliases of dns: ");

            host.Aliases
                .ToList()
                .ForEach(alias => result.Append($"{alias}, "));

            return result.ToString();
        }
        public string GetComputerNetworkData()
        {
            StringBuilder result = new StringBuilder();
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            result.AppendLine($"имя компьютера: {computerProperties.HostName}");
            result.AppendLine($"имя домена: {computerProperties.DomainName}");
            return result.ToString();
        }

        public string GetLoopback()
        {

            var result = new StringBuilder();
            result.AppendLine($"Loopback v4: {IPAddress.Loopback}");
            result.AppendLine($"Loopback v6: {IPAddress.IPv6Loopback}");
            return result.ToString();
        }

        public string GetBroadcastAddress()
        {
            var result = new StringBuilder();
            result.AppendLine($"Broadcast v4: {IPAddress.Broadcast}");
            result.AppendLine("Broadcast v6: Not Supported");
            return result.ToString();
        }

        public string GetAny()
        {
            var result = new StringBuilder();
            result.AppendLine($"Any v4: {IPAddress.Any}");
            result.AppendLine($"Any v6: {IPAddress.IPv6Any}");
            return result.ToString();
        }
    }
}
