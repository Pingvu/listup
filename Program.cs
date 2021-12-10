using System;
using System.Collections.Generic;

class Program {

static int Minsta(List<int> listan) {
 int re = listan[0];
 for(int i = 0; i < listan.Count; i++){
     if ( re > listan[i]){
         re = listan[i];
     }
 }
 return(re);
}

static int Största(List<int> listan) {
int re = listan[0];
 for(int i = 0; i < listan.Count; i++){
     if ( re < listan[i]){
         re = listan[i];
         return(listan[i]);
     }
     
 }
 return(re);
}

static void SkrivUt(List<int> listan) {
 for(int i= 0 ; i< listan.Count; i++){
     Console.WriteLine(listan[i]);
 }
}

public static void Main (string[] args) {
List<int> minLista = new List<int>();
minLista.Add(11); minLista.Add(5);
minLista.Add(12); minLista.Add(3);
minLista.Add(6); minLista.Add(3);

SkrivUt(minLista);

Console.WriteLine("Största tal: "+Största(minLista));
Console.WriteLine("Minsta tal: "+Minsta(minLista));

}
}
