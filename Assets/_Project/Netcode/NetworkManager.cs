using System.Net;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public int port;
    [SerializeField] int ip;

    void Start()
    {
        Debug.Log("DnsGetHostEntry: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0]);
        ip = (int)Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].AddressFamily;
    }

    void Update()
    {
        
    }
}
