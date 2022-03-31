Program Pzim ;
   var valor, precisa, rod1, rod2, media, rend : real;
       x : integer;
Begin
  x := 1;
  repeat
   clrscr;
   textcolor(10);
   write('QUANTAS CARTOLETAS CUSTA? ');
   readln(valor);
   precisa := valor * 0.382;
   writeln('MEDIA ESPERADA: ', precisa:0:2);
   write('PONTUAÇÃO PRIMEIRA RODADA: ');
   readln(rod1);
   write('PONTUAÇÃO SEGUNDA RODADA: ');
   readln(rod2);
   media := (rod1 + rod2) / 2;
   writeln('MEDIA: ',media:0:2);
   rend := media - precisa;   
   write('RENDIMENTO: ');
    if (rend < 0) then
     begin
      textcolor(12);
      write (rend:0:2);
     end 
     else
     begin
      textcolor(11);
      write (rend:0:2);
     end; 
   readkey;
  until x = 0;
End.