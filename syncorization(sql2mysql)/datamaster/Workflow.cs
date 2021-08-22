using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Workflow
    {
        public int ShsId { get; set; }
        public string TbName { get; set; }
        public string TbType { get; set; }
        public int RequestNo { get; set; }
        public int RequestNoSub { get; set; }
        public int ReferenceNo { get; set; }
        public string FiName { get; set; }
        public string FiNameSub { get; set; }
        public string FiNameType { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int? Status { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
