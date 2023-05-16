# ogrencinothesapuyg
<h1>Öğrenci Not Hesaplama Uygulaması</h1>

Öğrenci not hesaplama uygulaması, öğrencilerin aldıkları derslerin notlarını girmelerine ve not ortalamalarını hesaplamalarına yardımcı olan bir yazılım aracıdır. Bu uygulama genellikle öğrencilerin akademik performanslarını izlemelerine ve derslerindeki ilerlemelerini değerlendirmelerine olanak sağlar.

Öğrenci not hesaplama uygulamasının sağladığı faydalar şunlardır:

Kolaylık ve Hız: Uygulama, öğrencilerin notlarını tek bir yerde toplamasını ve hızlı bir şekilde hesaplamalarını yapmasını sağlar. Manuel olarak notları hesaplama ve takip etme zorunluluğunu ortadan kaldırır.

Doğruluk ve Hassasiyet: Uygulama, not hesaplama formüllerini otomatik olarak uygulayarak doğru ve hassas sonuçlar sağlar. El ile yapılan hesaplamalardaki hata riskini azaltır.

İlerlemeyi İzleme: Öğrenciler, ders notlarını ve ortalamalarını düzenli olarak takip ederek akademik ilerlemelerini izleyebilirler. Bu sayede zayıf alanlarını belirleyebilir ve gelişimlerini planlayabilirler.

Motivasyon ve Hedef Belirleme: Uygulama, öğrencilerin notlarını görsel olarak görüntülemelerine ve hedeflerini belirlemelerine olanak tanır. Başarılarına odaklanmalarını ve daha iyi sonuçlar elde etmeyi teşvik eder.


<h1>Öğrenci Not Hesaplama Uygulaması Nasıl Çalışır?</h1>


<div align="center"><img src="https://github.com/dmedya/ogrencinothesapuyg/blob/main/studentgradecal.png" width="300" height="300"></div>

Yukarıda da gördüğümüz üzere projemin ana sayfası budur .Burda gördüğünüz kutucuklara bilgilerini yazdıktan sonra 'calc' buttonuna basıp total kısmından genel sınav puanı ortalmasını ,avg kısmında ortalamasını ,sonuç kısmında ise harf notumuzu görürüz.


<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/notsuper.png" width="300" height="300"></div>

Yukarıda gördüğüz görselde notlarımı girdikten sonra Merhaba (girdiğimiz ad) Notun (ortalamaya göre notun nasıl olup olmadığı) çıktısı gözükecektir.Ben adımı ve bilgilerimi girdikten sonra Merhaba Medya Doran Super çıktısını aldım . 


Aşağıdaki görsellerde ise not değiştirilip ne çıktı alınacağını göstermek amacıyla eklenmiştir.Not İyi,Not İdare Eder ve Maalesef Kaldın çıktıları gösterilmiştir.

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/notiyi.png" width="300" height="300"></div>

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/notidareder.png" width="300" height="300"></div>

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/notkaldın.png" width="300" height="300"></div>



<h1>Bu Projeyi Nasıl Yaptım?</h1>

Öncelikle Visual Studio 2022 kod programını kullandım bu projem için. Programı açıp ordan windows form uygulaması ile bir proje oluşturuyoruz. Form oluşturma aşamaları aşağıdaki gibidir.

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/projeolu%C5%9Ftur.png" width="400" height="300"></div>

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/formsec.png " width="600" height="300"></div>

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/form1.png" width="400" height="300"></div>

Araç kutusunda kısmında "GroupBoxu" bulup formumumuzda konumlandırıyoruz .Ardından sol altta özellikler kısmında text kısmında Form1 ismini de  Student Grade Calculator olarak değiştirip araç kutusunda  "label" ekleyip, konumlandırıp text kısmını düzenleyip Student Name ,Matematik...vb kısımları ekliyoruz.

"GroupBox" kısımlarını ekleyip "label"larımıza metin kutusu oluşturmuş oluyoruz."GroupBox"larımıza isim veriyoruz örneğin student name için oluşturduğumuz "GroupBox"'a txtStudentname ismini atadık mesela . Diğer "GroupBoxlarımızı" da aynı şekil halletmemiz gerekiyor hallettikten sonra kod kısmına geçiyoruz

<div align="center"><img src ="https://github.com/dmedya/ogrencinothesapuyg/blob/main/ilkad%C4%B1m.png" width="300" height="300"></div>

<h1>Kod Kısmı</h1>

Bu kod bloğu, bir butona tıklandığında çalışacak bir olay işleyicisidir. Bu olay işleyicisi, öğrencinin matematik, İngilizce ve fen derslerinde aldığı notları alır, toplamını ve ortalamasını hesaplar ve ardından öğrencinin notuna göre bir harf notu ve açıklama belirler.



            double maths, english, science, total, avg;
            string grade, des;

            maths = int.Parse(txtMaths.Text);
            english = int.Parse(txtEnglish.Text);
            science = int.Parse(txtScience.Text);
           //yukaridaki üç satır matematik, ingilizce ve fen notlarını ve toplamını hesaplamak için değişkenleri tanımlar.

            total = maths + english + science;
            txtTotal.Text = total.ToString();
            avg = total / 3;
            //  yukarıdaki üç satır toplamı hesaplar ve sonucu ilgili metin kutularına yazar.
            txtAvg.Text = avg.ToString("0.00"); 
            // virgülden sonrası 2 basamak olucak şekilde yazar çok kalabalık gözükmesini önlemek amacıyla sayının ondalığını 2 basamaklı verir

            if (avg >= 75) //75 ve üstü A notunu alır
            {
                grade = "A";
                des = $"Merhaba {txtStudentName.Text} Notun Super..";
            }
            else if (avg >= 65) //65 ve üstü B 
            {
                grade = "B";
                des = $"Merhaba {txtStudentName.Text} Notun Iyi..";
            }
            else if (avg >= 55)
            {
                grade = "C";
                des = $"Merhaba {txtStudentName.Text} Notun Idare Eder..";
            }
            else if (avg >= 45)
            {
                grade = "D";
                des = $"Merhaba {txtStudentName.Text} Notun Kotu..";
            }
            else
            {
                grade = "F";
                des = $"Merhaba {txtStudentName.Text} Malesef Kaldin..";
            }
            description.Text = des.ToString();
            txtGrade.Text = grade.ToString();
            //belirlenen harf notu ve açıklama ilgili metin kutularına yazdırılır.

        }



       

       




