﻿// по  номеру четверти дает диапозон для X Y
Console.Clear();
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
if(num == 1) Console.WriteLine("X>0, Y>0");
if(num == 4) Console.WriteLine("X>0, Y<0");
if(num == 2) Console.WriteLine("X<0, Y>0");
if(num == 3) Console.WriteLine("X>0, Y<0");
if(num <1 || num >4) Console.WriteLine("Нет такого номера четверти");