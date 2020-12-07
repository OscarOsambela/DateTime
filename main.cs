using System;

class MainClass {
  public static void Main (string[] args) {
    //asignar una fecha
    DateTime nacimiento = new DateTime(2018, 10, 10);
    Console.WriteLine("Mi fecha de nacimiento es (MM/DD/YYYY) {0}", nacimiento);
  
    //mostrar fecha actual y hora
    Console.WriteLine(DateTime.Today);
    Console.WriteLine(DateTime.Now);
    DateTime maniana = ProximoDia();
    Console.WriteLine("El día de mañana es {0}", maniana);//*
    Console.WriteLine("Hoy es {0}", DateTime.Today.DayOfWeek);
    Console.WriteLine(PrimerDiaAnio(1999));//**
    int dias = DateTime.DaysInMonth(2000, 2);
      Console.WriteLine("El mes de febrero 2000 tuvo {0} días", dias);
    
    DateTime ahora = DateTime.Now;
    Console.WriteLine("minutos: {0}", ahora.Minute);
    Console.WriteLine("hora: {0}, minutos: {1}, segundos {2}", ahora.Hour, ahora.Minute, ahora.Second);
    Console.WriteLine("Ingrese una fecha en el siguiente formato: yyyy-mm-dd");
    string ingreso = Console.ReadLine();
    if(DateTime.TryParse(ingreso, out nacimiento)){
      Console.WriteLine(nacimiento);
      TimeSpan diasEnteros = ahora.Subtract(nacimiento);//timespan .- periodo de tiempo
      Console.WriteLine("Días que pasaron desde esa fecha: {0}", diasEnteros.Days);
    }else{
      Console.WriteLine("Ingreso incorrecto");
    }

  }

  //*
  static DateTime ProximoDia(){
    return DateTime.Today.AddDays(1);
  }
  //**
  static DateTime PrimerDiaAnio(int anio){
    return new DateTime(anio, 1, 1);
  }
}
