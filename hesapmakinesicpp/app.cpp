
#include <iostream>
using namespace std;
int main() {

    int sayi1, sayi2, secilenIslem,sonuc;
    cout <<"lutfen 1.sayi giriniz:";
    cin >> sayi1;
    cout << "Lutfen 2. sayi giriniz:";
    cin >> sayi2;

    cout << "Lutfen isleminizi seciniz(1:+, 2:-, 3:*, 4:/):";
    cin >> secilenIslem;
    cout << endl;

    if (secilenIslem == 1) {
    sonuc = sayi1 + sayi2;
    }
    else if (secilenIslem == 2) {
    sonuc = sayi1 - sayi2;
    }
    else if (secilenIslem == 3) {
    sonuc = sayi1 * sayi2;
    }
    else if (secilenIslem == 4) {
    sonuc = sayi1 / sayi2;
    }
    else 
    {
    cout << "Lutfen 1 ile 4 arasinda bir deger giriniz!!";
    }
    cout << "İsleminizin sonucu = " << sonuc;
    


    return 0;
}



    





    




    
