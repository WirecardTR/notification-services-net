using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace notification_services_net
{
    public class input
    {
        public Guid OrderObjectId { get; set; }
        public string GSM { get; set; }
        public string MPAY { get; set; }
        public string SMSContent { get; set; }
        public double TotalPrice { get; set; }
        public double TotalUnitPrice { get; set; }
        public int State { get; set; }
        public int StatusCode { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public  DateTime PaymentDateTime { get; set; }
        public int GsmOperator { get; set; }
        public  int GsmType { get; set; }
        public  Guid SubscriberId { get; set; }
        public List<CSaleProduct> Products { get; set; }
        public  int OrderChannelId { get; set; }
        public int PaymentTypeId { get; set; }
        public int PaymentCategoryId { get; set; }
        public string Pin { get; set; }
    }
}