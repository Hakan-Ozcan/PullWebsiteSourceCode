using System.Net;

WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("https://www.apple.com/tr/");
WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
string KaynakKodlar = CevapOku.ReadToEnd();
//int IcerikBaslangicIndex = KaynakKodlar.IndexOf("<h6>") + 4;
//int IcerikBitisIndex = KaynakKodlar.Substring(IcerikBaslangicIndex).IndexOf("</h6>");
//Console.WriteLine(KaynakKodlar.Substring(IcerikBaslangicIndex, IcerikBitisIndex));
Console.WriteLine(KaynakKodlar);
Console.Read();