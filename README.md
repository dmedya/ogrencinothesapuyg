# ogrencinothesapuyg
<h1>Öğrenci Not Hesaplama Uygulaması</h1>

Öğrenci not hesaplama uygulaması, öğrencilerin aldıkları derslerin notlarını girmelerine ve not ortalamalarını hesaplamalarına yardımcı olan bir yazılım aracıdır. Bu uygulama genellikle öğrencilerin akademik performanslarını izlemelerine ve derslerindeki ilerlemelerini değerlendirmelerine olanak sağlar.

Öğrenci not hesaplama uygulamasının sağladığı faydalar şunlardır:

<h5>Kolaylık ve Hız:</h5> Uygulama, öğrencilerin notlarını tek bir yerde toplamasını ve hızlı bir şekilde hesaplamalarını yapmasını sağlar. Manuel olarak notları hesaplama ve takip etme zorunluluğunu ortadan kaldırır.

<h5>Doğruluk ve Hassasiyet:</h5> Uygulama, not hesaplama formüllerini otomatik olarak uygulayarak doğru ve hassas sonuçlar sağlar. El ile yapılan hesaplamalardaki hata riskini azaltır.

<h5>İlerlemeyi İzleme:</h5> Öğrenciler, ders notlarını ve ortalamalarını düzenli olarak takip ederek akademik ilerlemelerini izleyebilirler. Bu sayede zayıf alanlarını belirleyebilir ve gelişimlerini planlayabilirler.

<h5>Motivasyon ve Hedef Belirleme:</h5> Uygulama, öğrencilerin notlarını görsel olarak görüntülemelerine ve hedeflerini belirlemelerine olanak tanır. Başarılarına odaklanmalarını ve daha iyi sonuçlar elde etmeyi teşvik eder.


<h2>Öğrenci Not Hesaplama Uygulaması Nasıl Çalışır?</h2>


<div align="center"><img src="https://github.com/dmedya/ogrencinothesapuyg/blob/main/anaekran.png" width="auto"></div>

Yukarıda gördüğümüz ana ekranım.Ana ekranımın yan tarafında add student butonuna tıklayıp aşağıda da gördüğümüz üzere öğrencilerin bilgilerini gireceği bir form sayfası çıkıyor karşımıza.Buraya bilgilerimizi girip 'calc' yaptığımızda not hesaplanıyor ve not ana ekranımda listeleniyor.


<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/anaekran1.png" width="auto"></div>



<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/anaekran2.png" width="auto"></div>







<h2>Bu Projeyi Nasıl Yaptım?</h2>

Öncelikle Visual Studio 2022 kod programını kullandım bu projem için. Programı açıp ordan windows form uygulaması ile bir proje oluşturuyoruz. Form oluşturma aşamaları aşağıdaki gibidir.

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/projeolu%C5%9Ftur.png" width="800" height="700"></div>

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/formsec.png " width="800" height="700"></div>

<div align="center"><img src = "https://github.com/dmedya/ogrencinothesapuyg/blob/main/form1.png" width="800" height="700"></div>

Araç kutusunda kısmında "GroupBoxu" bulup formumumuzda konumlandırıyoruz .Ardından sol altta özellikler kısmında text kısmında Form1 ismini de  Student Grade Calculator olarak değiştirip araç kutusunda  "label" ekleyip, konumlandırıp text kısmını düzenleyip Student Name ,Matematik...vb kısımları ekliyoruz.

"GroupBox" kısımlarını ekleyip "label"larımıza metin kutusu oluşturmuş oluyoruz."GroupBox"larımıza isim veriyoruz örneğin student name için oluşturduğumuz "GroupBox"'a txtStudentname ismini atadık mesela . Diğer "GroupBoxlarımızı" da aynı şekil halletmemiz gerekiyor hallettikten sonra kod kısmına geçiyoruz

<div align="center"><img src ="https://github.com/dmedya/ogrencinothesapuyg/blob/main/ilkad%C4%B1m.png" width="800" height="700"></div>

<h2>Kod Kısmı</h2>

Bu kod bloğu, bir butona tıklandığında çalışacak bir olay işleyicisidir. Bu olay işleyicisi, öğrencinin matematik, İngilizce ve fen derslerinde aldığı notları alır, toplamını ve ortalamasını hesaplar ve ardından öğrencinin notuna göre bir harf notu ve açıklama belirler.



          



       

       




