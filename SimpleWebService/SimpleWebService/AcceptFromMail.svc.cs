﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SimpleWebService.Model;

namespace SimpleWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AcceptFromMail : IAcceptFromMail
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public AcceptModel SetAnswer(AcceptModel accept)
        {
            if (accept == null)
            {
                Debug.WriteLine("Valami nem jó");
            } else
            {
                Debug.WriteLine("Siker");
            }

            AcceptModel valasz = new AcceptModel
            {
                answer = "Válasz"
            };
            return valasz;
        }
    }
}
