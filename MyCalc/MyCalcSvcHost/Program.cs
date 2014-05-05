﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using MyCalcSvc;

namespace MyCalcSvcHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:8090/MyService/SimpleCalculator");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(MyCalcSvc.SimpleCalculator), httpUrl));
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(MyCalcSvc.ISimpleCalculator), new WSHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();

            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }
    }
}
