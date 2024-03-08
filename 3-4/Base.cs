using System;
public abstract class BaseArray:IArray
   {
       protected abstract void Input(); 
       protected abstract void Rand();  
       public abstract void Output();
       public abstract double Avg();
   }
