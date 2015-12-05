using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancerApp
{
    public class Loadbalancer
    {
        private static Loadbalancer _instance;

        private static object syncLock = new object();

        private List<string> _servers = new List<string>();

        private Random _randomGenerator = new Random(); 

        private Loadbalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }
        public static Loadbalancer GetInstance()
        {
            if (_instance == null)
            { 
                lock(syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Loadbalancer();
                    }
                }
            }

            return _instance;
        }

        public string Server
        {
            get 
            {
                int count = _randomGenerator.Next(_servers.Count);    
                return _servers[count];
            }
        }

    }
}
