ilkSayi = int(input("İlk Sayıyı Giriniz: "))
İkinciSayi = int(input("İkinci sayıyı Giriniz"))
islem = input("""Yapmak İstediğiniz İşlemi Giriniz.
Toplama: +, Çıkarma:-, Çarpma: x, Bölme: /)
""")

if islem == "+":
    print("Sonuç: " +str(ilkSayi+İkinciSayi))

elif islem == "-":
    print("Sonuç: " + str(ilkSayi - İkinciSayi))

elif islem == "x":
    print("Sonuç: " + str(ilkSayi * İkinciSayi))

elif islem == "/":
    print("Sonuç: " + str(ilkSayi / İkinciSayi))
