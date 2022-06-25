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
    class Lop
    {
        private string khoa;
        private string malop;
        private string siso;
        public string Khoa { get => khoa; set => khoa = value; }
        public string MaLop { get => malop; set => malop = value; }
        public string SiSo { get => siso; set => siso = value; }
        public Lop(string khoa, string malop, string siso)
        {
            Khoa = khoa;
            MaLop = malop;
            SiSo = siso;
        }
        public Lop(DataRow row)
        {
            Khoa = row["Khoa"].ToString();
            MaLop = row["MaLop"].ToString();
            SiSo = row["SiSo"].ToString();
        }
        private XmlDocument doc = new XmlDocument();
        XmlTextWriter write;
        private XmlElement root;
        private string FileName = @"../../XML/Lop.xml";
        public Lop()
        {
            if (File.Exists(FileName))
            {
                doc.Load(FileName);
                root = doc.DocumentElement;
            }
            else
            {
                write = new XmlTextWriter("Lop.xml", System.Text.Encoding.UTF8);
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
        private bool Check(XmlNode xNode, string MaLop)
        {
            xNode = root.SelectSingleNode("Lop[MaLop='" + MaLop + "']");
            if (xNode != null)
                return true;
            else
                return false;
        }
        public void Them(Lop l)
        {
            XmlElement Lop = doc.CreateElement("Lop");
            XmlElement MaLop = doc.CreateElement("MaLop");
            if (Check(MaLop, l.MaLop))
            { }
            else
            {
                MaLop.InnerText = l.MaLop;
                Lop.AppendChild(MaLop);

                XmlElement Khoa = doc.CreateElement("Khoa");
                Khoa.InnerText = l.Khoa;
                Lop.AppendChild(Khoa);

                XmlElement SiSo = doc.CreateElement("SiSo");
                SiSo.InnerText = l.SiSo;
                Lop.AppendChild(SiSo);
                root.AppendChild(Lop);
                doc.Save(FileName);
            }
        }
        public void Sua(Lop l)
        {
            XmlNode NodeOld = root.SelectSingleNode("Lop[MaLop='" + l.MaLop + "']");

            if (NodeOld != null)
            {
                XmlNode NodeNew = doc.CreateElement("Lop");
                XmlElement MaLop = doc.CreateElement("MaLop");
                MaLop.InnerText = l.MaLop;
                NodeNew.AppendChild(MaLop);
                XmlElement Khoa = doc.CreateElement("Khoa");
                Khoa.InnerText = l.Khoa;
                NodeNew.AppendChild(Khoa);
                XmlElement SiSo = doc.CreateElement("SiSo");
                SiSo.InnerText = l.SiSo;
                NodeNew.AppendChild(SiSo);
                root.ReplaceChild(NodeNew, NodeOld);
                doc.Save(FileName);
            }
        }
        public void Xoa(Lop l)
        {
            XmlNode nodeDelete = root.SelectSingleNode("Lop[MaLop='" + l.MaLop + "']");
            if (nodeDelete != null)
            {
                root.RemoveChild(nodeDelete);
                doc.Save(FileName);
            }
        }

        public List<Lop> Search(string input)
        {
            var node = root.SelectNodes("Lop[MaLop='" + input + "']");
            List<Lop> listLop = new List<Lop>();
            if (node.Count > 0)
            {
                for (int i = 0; i < node.Count; i++)
                {
                    Lop l = new Lop(
                        node[i].ChildNodes.Item(0).InnerText.Trim(),
                        node[i].ChildNodes.Item(1).InnerText.Trim(),
                        node[i].ChildNodes.Item(2).InnerText.Trim()
                        );
                    listLop.Add(l);
                }
            }
            return listLop;
        }
        public List<Lop> Load()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList list;
            FileStream fs = new FileStream(@"../../XML/Lop.xml", FileMode.Open, FileAccess.ReadWrite);
            xmldoc.Load(fs);
            fs.Close();
            list = xmldoc.GetElementsByTagName("Lop");
            List<Lop> listLop = new List<Lop>();
            for (int i = 0; i < list.Count; i++)
            {
                Lop cl = new Lop(list[i].ChildNodes.Item(0).InnerText.Trim(),
                     list[i].ChildNodes.Item(1).InnerText.Trim(),
                     list[i].ChildNodes.Item(2).InnerText.Trim()
                    );
                listLop.Add(cl);
            }
            return listLop;
        }
    }
}
