using System;
namespace EntityLayer.Concrete
{
	public class Guide
	{
		public int GuideID { get; set; }
		public int Name { get; set; }
		public int Descripton { get; set; }
        public int Image { get; set; }
        public int TwitterUrl { get; set; }
        public int InstagramUrl { get; set; }
        public bool Status { get; set; }
    }
}

