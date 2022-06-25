using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TieuLuanXML.Models
{
    class GiaoVien
    {
        private string maGiaoVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string lop;
        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public GiaoVien(string maGiaoVien, string hoTen, DateTime ngaySinh, string lop)
        {
            MaGiaoVien = maGiaoVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Lop = lop;
        }
        public GiaoVien(DataRow row)
        {
            MaGiaoVien = row["MaGiaoVien"].ToString();
            HoTen = row["HoTen"].ToString();
            NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
            Lop = row["Lop"].ToString();
        }
        private XmlDocument doc = new XmlDocument();
        XmlTextWriter write;
        private XmlElement root;
        private string FileName = @"../../XML/GiaoVien.xml";
        public GiaoVien()
        {
            if (File.Exists(FileName))
            {
                doc.Load(FileName);
                root = doc.DocumentElement;
            }
            else
            {
                write = new XmlTextWriter("GiaoVien.xml", System.Text.Encoding.UTF8);
                write.WriteStartDocument(true);
                write.Formatting = Formatting.Indented;
                write.Indentation = 2;
                write.WriteStartElement("root");
                write.WriteEndElement();
                write.WriteEndDocument();
                write.Close();
                doc.Load(FileName);
                root = doc.DocumentElement;
            }
        }
        private bool Check(XmlNode xNode, string MaGiaoVien)
        {
            xNode = root.SelectSingleNode("GiaoVien[MaGiaoVien='" + MaGiaoVien + "']");
            if (xNode != null)
                return true;
            else
                return false;
        }
        public void Them(GiaoVien sv)
        {
            XmlElement GiaoVien = doc.CreateElement("GiaoVien");
            XmlElement MaSV = doc.CreateElement("MaGiaoVien");
            if (Check(MaSV, sv.MaGiaoVien))
            { }
            else
            {
                MaSV.InnerText = sv.MaGiaoVien;
                GiaoVien.AppendChild(MaSV);

                XmlElement HoTen = doc.CreateElement("HoTen");
                HoTen.InnerText = sv.HoTen;
                GiaoVien.AppendChild(HoTen);
                XmlElement NgaySinh = doc.CreateElement("NgaySinh");
                NgaySinh.InnerText = sv.NgaySinh.ToShortDateString();
                GiaoVien.AppendChild(NgaySinh);
                XmlElement Lop = doc.CreateElement("Lop");
                Lop.InnerText = sv.Lop;
                GiaoVien.AppendChild(Lop);
                root.AppendChild(GiaoVien);
                doc.Save(FileName);
            }
        }
        public void Sua(GiaoVien sv)
        {
            XmlNode NodeOld = root.SelectSingleNode("GiaoVien[MaGiaoVien='" + sv.MaGiaoVien + "']");

            if (NodeOld != null)
            {
                XmlNode NodeNew = doc.CreateElement("GiaoVien");
                XmlElement MaSV = doc.CreateElement("MaGiaoVien");
                MaSV.InnerText = sv.MaGiaoVien;
                NodeNew.AppendChild(MaSV);
                XmlElement HoTen = doc.CreateElement("HoTen");
                HoTen.InnerText = sv.HoTen;
                NodeNew.AppendChild(HoTen);
                XmlElement NgaySinh = doc.CreateElement("NgaySinh");
                NgaySinh.InnerText = sv.NgaySinh.ToShortDateString();
                NodeNew.AppendChild(NgaySinh);
                XmlElement Lop = doc.CreateElement("Lop");
                Lop.InnerText = sv.Lop;
                NodeNew.AppendChild(Lop);
                root.ReplaceChild(NodeNew, NodeOld);
                doc.Save(FileName);
            }
        }
        public void Xoa(GiaoVien sv)
        {
            XmlNode nodeDelete = root.SelectSingleNode("GiaoVien[MaGiaoVien='" + sv.MaGiaoVien + "']");
            if (nodeDelete != null)
            {
                root.RemoveChild(nodeDelete);
                doc.Save(FileName);
            }
        }

        public List<GiaoVien> Search(string input)
        {
            var node = root.SelectNodes("GiaoVien[MaGiaoVien='" + input + "']");
            List<GiaoVien> listSV = new List<GiaoVien>();
            if (node.Count > 0)
            {
                for (int i = 0; i < node.Count; i++)
                {
                    GiaoVien sv = new GiaoVien(
                        node[i].ChildNodes.Item(0).InnerText.Trim(),
                        node[i].ChildNodes.Item(1).InnerText.Trim(),
                        Convert.ToDateTime(node[i].ChildNodes.Item(2).InnerText.Trim()),
                        node[i].ChildNodes.Item(3).InnerText.Trim()
                        );
                    listSV.Add(sv);
                }
            }
            return listSV;
        }
        public List<GiaoVien> Load()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList list;
            FileStream fs = new FileStream(@"../../XML/GiaoVien.xml", FileMode.Open, FileAccess.ReadWrite);
            xmldoc.Load(fs);
            fs.Close();
            list = xmldoc.GetElementsByTagName("GiaoVien");
            List<GiaoVien> ListSV = new List<GiaoVien>();
            for (int i = 0; i < list.Count; i++)
            {
                GiaoVien cl = new GiaoVien(list[i].ChildNodes.Item(0).InnerText.Trim(),
                     list[i].ChildNodes.Item(1).InnerText.Trim(),
                      Convert.ToDateTime(list[i].ChildNodes.Item(2).InnerText),
                       list[i].ChildNodes.Item(3).InnerText.Trim()
                    );
                ListSV.Add(cl);
            }
            return ListSV;
        }
    }
}
