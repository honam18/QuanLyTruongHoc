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
    class SinhVien
    {
        private string maSinhVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string lop;
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string lop)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Lop = lop;
        }
        public SinhVien(DataRow row)
        {
            MaSinhVien = row["MaSinhVien"].ToString();
            HoTen = row["HoTen"].ToString();
            NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
            Lop = row["Lop"].ToString();
        }
        private XmlDocument doc = new XmlDocument();
        XmlTextWriter write;
        private XmlElement root;
        private string FileName = @"../../XML/SinhVien.xml";
        public SinhVien()
        {
            if (File.Exists(FileName))
            {
                doc.Load(FileName);
                root = doc.DocumentElement;
            }
            else
            {
                write = new XmlTextWriter("sinhvien.xml", System.Text.Encoding.UTF8);
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
        private bool Check(XmlNode xNode, string MaSinhVien)
        {
            xNode = root.SelectSingleNode("SinhVien[MaSinhVien='" + MaSinhVien + "']");
            if (xNode != null)
                return true;
            else
                return false;
        }
        public void Them(SinhVien sv)
        {
            XmlElement SinhVien = doc.CreateElement("SinhVien");
            XmlElement MaSV = doc.CreateElement("MaSinhVien");
            if (Check(MaSV, sv.MaSinhVien))
            { }
            else
            {
                MaSV.InnerText = sv.MaSinhVien;
                SinhVien.AppendChild(MaSV);

                XmlElement HoTen = doc.CreateElement("HoTen");
                HoTen.InnerText = sv.HoTen;
                SinhVien.AppendChild(HoTen);
                XmlElement NgaySinh = doc.CreateElement("NgaySinh");
                NgaySinh.InnerText = sv.NgaySinh.ToShortDateString();
                SinhVien.AppendChild(NgaySinh);
                XmlElement Lop = doc.CreateElement("Lop");
                Lop.InnerText = sv.Lop;
                SinhVien.AppendChild(Lop);
                root.AppendChild(SinhVien);
                doc.Save(FileName);
            }
        }
        public void Sua(SinhVien sv)
        {
            XmlNode NodeOld = root.SelectSingleNode("SinhVien[MaSinhVien='" + sv.MaSinhVien + "']");

            if (NodeOld != null)
            {
                XmlNode NodeNew = doc.CreateElement("SinhVien");
                XmlElement MaSV = doc.CreateElement("MaSinhVien");
                MaSV.InnerText = sv.MaSinhVien;
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
        public void Xoa(SinhVien sv)
        {
            XmlNode nodeDelete = root.SelectSingleNode("SinhVien[MaSinhVien='" + sv.MaSinhVien + "']");
            if (nodeDelete != null)
            {
                root.RemoveChild(nodeDelete);
                doc.Save(FileName);
            }
        }

        public List<SinhVien> Search(string input)
        {
            var node = root.SelectNodes("SinhVien[MaSinhVien='" + input + "']");
            List<SinhVien> listSV = new List<SinhVien>();
            if (node.Count > 0)
            {
                for (int i = 0; i < node.Count; i++)
                {
                    SinhVien sv = new SinhVien(
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
        public List<SinhVien> Load()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList list;
            FileStream fs = new FileStream(@"../../XML/SinhVien.xml", FileMode.Open, FileAccess.ReadWrite);
            xmldoc.Load(fs);
            fs.Close();
            list = xmldoc.GetElementsByTagName("SinhVien");
            List<SinhVien> ListSV = new List<SinhVien>();
            for (int i = 0; i < list.Count; i++)
            {
                SinhVien cl = new SinhVien(list[i].ChildNodes.Item(0).InnerText.Trim(),
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
