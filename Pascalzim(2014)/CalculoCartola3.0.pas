Program Pzim ;
   var valor, precisa, mediaatual, ponttotal, rod, part, mediaaux, mediafinal, rend : real;
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
   write('JOGOU QNTS PARTIDAS CONTANDO COM A ATUAL: ');
   readln(part);
   write('MÉDIA ATUAL: ');
   readln(mediaatual);
   write('PONTUAÇÃO DA RODADA: ');
   readln(rod);
   ponttotal := mediaatual * (part - 1);
   mediafinal := (rod + ponttotal) / part;
   writeln('MEDIA: ',mediafinal:0:2);
   rend := mediafinal - precisa;   
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
