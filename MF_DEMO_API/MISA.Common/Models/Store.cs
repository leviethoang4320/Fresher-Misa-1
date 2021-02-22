using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class Store
    {
        public Store()
        {

            StoreId = Guid.NewGuid();
            Status = "Đang hoạt động";
        }
        public Guid StoreId { get; set; }
        public String StoreId_
        {

            get
            {
                return StoreId.ToString();
            }
        }


        [Required("Mã cửa hàng")]
        [CheckDuplicate("Mã cửa hàng")]
        [MaxLength("Mã cửa hàng", 20)]
        public string StoreCode { get; set; }

        [Required("Tên cửa hàng")]
        public string StoreName { get; set; }
       
      

        [Required("Số điện thoại")]
        [CheckDuplicate("Số điện thoại")]
        public string PhoneNumber { get; set; }

        public string Status { get; set; }

        [Required("Tên cửa hàng")]
        public string Address { get; set; }
        public Guid WardId { get; set; }
        public String WardId_
        {
            get
            {
                return WardId.ToString();
            }
        }

    }
}

