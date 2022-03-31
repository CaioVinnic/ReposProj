Program Pzim ;

var p1, p2, integ, m2, media : real;
    i : integer;

Begin
   
   repeat
   
   textcolor(white);
   GOTOXY (01, 25); write('v2.0 - VINNIC');
   
   textcolor(lightcyan);
   
   GOTOXY (21, 3); write('=== Utilize PONTOS ao invés de VÍRGULAS ===');
   
   GOTOXY (36, 7); write('P1: ');
                   readln(p1);
                   
   GOTOXY (36, 8); write('P2: ');
                   readln(p2);
                   
   GOTOXY (36, 9); write('Integrada: ');
                   readln(integ);
   
   
   m2 := ((p2*0.7) + (integ*0.3));
   media := ((p1 + (m2*2))/3);
   
   GOTOXY (33, 11); write('MEDIA FINAL: ');
   textcolor(white);
   GOTOXY (46, 11); write(media:0:2);
   textcolor(lightcyan);
   i:=i;
   
   if (media>10) then
      begin
       clrscr;
       GOTOXY (28, 13); write('ERRO!!! MÉDIA MAIOR QUE 10');
      end;
      
   if (media>=5) and (media<=10) then
      begin
       GOTOXY (27, 16); write('*   APROVADO!!! BOA PARÇA   *');
      end;
      
   if (media>=3) and (media<5) then
       begin
        GOTOXY (27, 16); write('*   FIATINHO TÁ DE EXAME!   *')
       end;     
        
   if (media>0) and (media<3) then
       begin
        GOTOXY (30, 16); write('*   NOOB FICOU DE DP   *');
       end;
   
   textcolor(white);
   
   GOTOXY (34, 22); write('PRESSIONE ENTER');
   readkey;
   
   clrscr;
   
   until i = 999;
End.
