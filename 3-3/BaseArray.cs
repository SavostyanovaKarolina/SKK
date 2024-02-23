using System;
public abstract class BaseArray:IArray,IPrinter
   {
       protected abstract void Input(); 
       protected abstract void Rand();  
       public abstract void Output();
       public abstract double Avg();
   }
