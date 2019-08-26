using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.IO;
using GoldenShoe.Models;
using Newtonsoft.Json;
using System.Web.Hosting;

namespace GoldenShoe.Controllers
{
    public class ComplaintController : ApiController
    {
        List<ComplaintModel> complaints = new List<ComplaintModel>();

        // GET: api/Complaint
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Complaint/5
        public string Get(int id)
        {
            return "value";
        }

        //[HttpPost]
       //  [ActionName("addComplaint")]
        //POST: api/complaint
        public void Post([FromBody]ComplaintModel complaint)
        {
            Guid complaintNumberGenerated = Guid.NewGuid();
            //complaints.Add(complaint);

            string productID = complaint.productSelect;
            string reasonID = complaint.reasonSelect;
            string description = complaint.description;
            string reasonText;

            switch (Int32.Parse(reasonID))
            {
                case 1:
                    complaint.reason = "Incorrent size";
                    break;
                case 2:
                    complaint.reason = "Don`t like the colour";
                    break;
                case 3:
                    complaint.reason = "Don`t like the style";
                    break;
                case 4:
                    complaint.reason = "Other";
                    break;
                default:
                    break;
            }

            complaint.complainID = complaintNumberGenerated.ToString();

            using (StreamWriter writer = File.AppendText(HostingEnvironment.MapPath("~/App_Data/complains.txt")))
            {
                writer.WriteLine(JsonConvert.SerializeObject(complaint));
            }
        }

        // PUT: api/Complaint/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Complaint/5
        public void Delete(int id)
        {
        }
    }
}
