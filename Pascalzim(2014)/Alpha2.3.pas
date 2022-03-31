Program Trabalho_Almir ;

Type Motorista=record
		       			    id:integer;
		         					nome:string;
				       	    codigo:string;
				       	   end; 
  			mot=array[1..5] of Motorista;
			
Type Veiculo=record
		       			  id:integer;
			        			modelo:string;
		        				placa:string;
		         		end;	
	   	veic=array[1..5] of Veiculo;
			
Type Custo=record
		       			peso:real;
		       			adc:real;
		       			cpeso:real;
		       			tipo:char;
		       			dist:real;
	       				cuscomb:real;
		       			total:real;
		      		 end;
 	   cust=array[1..5] of Custo;		

Procedure CadMot (var cadM:boolean; var moto:mot; var num:integer; var maxmot:boolean);
var resp:char; 
	  	ab:boolean;
		
begin
	cadm:=false;
	if maxmot=false then
	begin
		repeat
		 ab:=true;
		 clrscr;
  	 if num<=5 then
		 begin
			Gotoxy(10, 4);  Writeln('**************************************************************');
   Gotoxy(10, 5);  Writeln('*   ID   /5        Cadastro de Motoristas                    *');
   Gotoxy(10, 6);  Writeln('*                                                            *');
 		Gotoxy(10, 7);  writeln('*   Nome:                                                    *');         
 		Gotoxy(10, 8);  Writeln('*   Codigo:                                                  *'); 
			Gotoxy(10, 9);  Writeln('*                                                            *');
			Gotoxy(10,10);  Writeln('*                  SAIR? s/n                                 *');
			if num = 5 then begin
			gotoxy(15,10);  write  ('                                     '                         ); end;                   
 		Gotoxy(10,11);  Writeln('*                                                            *');
 		Gotoxy(10,12);  Writeln('**************************************************************');
	  Gotoxy(18, 5);  Writeln(num);
			Gotoxy(22, 7);  read (moto[num].nome);
			Gotoxy(22, 8);  read (moto[num].codigo);
      if num < 5 then begin
			 repeat
				 gotoxy(40,10);  read (resp);
			 until(resp='S')or(resp='s')or(resp='N')or(resp='n');                         
			end;
			moto[num].id:=moto[num].id+1;  	
		  num:=num+1;
		  cadm:=true;
		 end;
			if (resp='s')or(resp='S') then
			    break;
		  if num=6 then
		   begin
			  maxmot:=true;
			  num:=num-1;
			 end;
		until (maxmot=true);
		if maxmot=true then
		 begin
		  clrscr;
		  ab:=false;
		 end;
	end;
	if ab=false then begin
	 gotoxy(30,13); textbackground(black); write('LIMITE DE 5, ATINGIDO!'); textbackground(blue); readkey;	end;
end;

Procedure CadVeic (var Cadv:boolean; var i:integer; var veicu:veic; var maxveic:boolean);
var	resp:char;
		ab:boolean;
		
Begin
	cadv:=false;
	if maxveic=false then
	 begin
		repeat
		 begin
		  ab:=true;
      clrscr;
      if i<=5 then
		  begin
  	   Gotoxy(10, 4);  Writeln('**************************************************************');
  	   Gotoxy(10, 5);  Writeln('*   ID   /5        Cadastro de Veiculos                      *');
  	   Gotoxy(10, 6);  Writeln('*                                                            *');
   		 Gotoxy(10, 7);  writeln('*   Modelo:                                                  *');         
      Gotoxy(10, 8);  Writeln('*   Placa:                                                   *');
	  		 Gotoxy(10, 9);  Writeln('*                                                            *');
	  		 Gotoxy(10,10);  Writeln('*                   SAIR? s/n                                *');
	  		 if i = 5 then   begin
	  		 gotoxy(15,10);  write  ('                                     '                         ); end;                    
      Gotoxy(10,11);  Writeln('*                                                            *');
      Gotoxy(10,12);  Writeln('**************************************************************');
   		 Gotoxy(18, 5);  Writeln(i);
			 Gotoxy(22, 7);  read (veicu[i].modelo);
			 Gotoxy(22, 8);  read (veicu[i].placa);
			 if i < 5 then begin
			 repeat
				 gotoxy(40,10);  read (resp);
			 until(resp='S')or(resp='s')or(resp='N')or(resp='n');                         
			 end;			    
  		 veicu[i].id:=veicu[i].id+1;
  		 i:=i+1;
  		 cadv:=true;
  		end;
			 if (resp='s')or(resp='S') then
			    break;
		 end;
		  if i=6 then
		   begin 
				maxveic:=true;
		    i:=i-1;
	     end;
		until (maxveic=true);
		if maxveic=true then
		 begin
		  clrscr;
		  ab:=false;
		 end;
	end;
	if ab=false then
	begin
	 gotoxy(30,13); textbackground(black); write('LIMITE DE 5, ATINGIDO!'); textbackground(blue);
	 readkey;
	end;	             

end;

Procedure Listagem (num:integer; moto:mot; veicu:veic; cus:cust; flag:string; var lin:integer; var i:integer);

begin
			if flag='viagem' then 
			 begin 
				lin:=9;
			  for i:=1 to num-1 do
			   begin 
				 	Gotoxy(10,lin); write('*');		   
			    Gotoxy(12,lin); textcolor(lightgreen); write('  ',i,' -');
					Gotoxy(19,lin); textcolor(white);      write(moto[i].nome); textbackground(blue); textcolor(black);
					Gotoxy(40,lin); write('|');           textbackground(blue); textcolor(white);
					Gotoxy(51,lin); textcolor(lightgreen); write(i,' -');
					Gotoxy(56,lin); textcolor(white);      write(veicu[i].modelo);
          Gotoxy(76,lin); write('*');
			    lin:=lin+1;
			   end;
			 end; 
			  
			if flag='relatmot' then 
			 begin
			  lin:=8;			 
			  for i:=1 to num-1 do
			   begin 			   
			    Gotoxy(10,lin); write('*        ',i); Gotoxy(37,lin); write(moto[i].nome); Gotoxy(55,lin); write(cus[i].total:0:2);
          Gotoxy(71,lin); write('*');
			    lin:=lin+1;
			   end;
			 end;				   
end;


Procedure CustoViagem (cadm:boolean; cadv:boolean; num:integer; RetMot:mot; RetVeic:veic; var Cus:Cust; var totcad:integer; var totger:real; var cadvia:boolean; ii:integer);
var i,linha,idmot,idveic,a:integer;
		flag:string;

begin
 if (cadm=true)and(cadv=true) then
	begin
   clrscr;
   repeat
    a:=1;
		Gotoxy(10, 4);        Writeln('*******************************************************************');
		textbackground(white);
	  textcolor(blue);
  Gotoxy(10, 5);        Writeln('*                   CADASTRO DE CUSTO DE VIAGEM                   *');
	  textbackground(blue);
	  textcolor(white);
  Gotoxy(10, 6);        Writeln('*******************************************************************');
		Gotoxy(10, 7);        Writeln('*   ID   Motorista                       ID   Veiculo             *');
  Gotoxy(10, 8);        Writeln('*                                                                 *');
  flag:='viagem';
		Listagem (num, RetMot, RetVeic, Cus, flag, linha, ii);
  Gotoxy(10,linha   );  Writeln('*                                                                 *');
		Gotoxy(10,linha+1 );  Writeln('*******************************************************************');
  Gotoxy(10,linha+2 );  Writeln('*                                                                 *');
  Gotoxy(10,linha+3 );  Writeln('*   ID do Motorista:                                              *');
  Gotoxy(10,linha+4 );  Writeln('*   ID do Veiculo:                                                *');
  Gotoxy(50,linha+3 ); textbackground(blue);textcolor(lightgreen); Writeln('Tipo Comb: A - Gaso/Alc');
  Gotoxy(50,linha+4 );  Writeln('           B - Etanol  ');textcolor(white); textbackground(blue);
  Gotoxy(10,linha+5 );  Writeln('*                                                                 *');
		Gotoxy(10,linha+6 );  Writeln('*   Nome Motorista:                     Codigo:                   *');
  Gotoxy(10,linha+7 );  Writeln('*   Modelo do Veiculo:                  Placa:                    *');
  Gotoxy(10,linha+8 );  Writeln('*   Tipo Combustivel:                   Distancia:                *');
  Gotoxy(10,linha+9 );  Writeln('*   Peso da Carga:                      Custo Peso:               *');
  Gotoxy(10,linha+10);  Writeln('*   Valor adicional:                    TOTAL:                    *');
		Gotoxy(10,linha+11);  Writeln('*                                                                 *');
		Gotoxy(10,linha+12);  Writeln('*******************************************************************');
		gotoxy(33,linha+3);   readln (idmot);
		 while idmot>ii do begin 
		  gotoxy(33,linha+3);   readln (idmot); end;                    
		gotoxy(33,linha+4);   readln (idveic);
		 while idveic>ii do begin 
		  gotoxy(33,linha+4);   readln (idveic); end;                     
		gotoxy(33,linha+6);   writeln(RetMot[idmot].nome);         
		gotoxy(62,linha+6);   writeln(RetMot[idmot].codigo);       				
		gotoxy(33,linha+7);   writeln(RetVeic[idveic].modelo);     
		gotoxy(62,linha+7);   writeln(RetVeic[idveic].placa);      
		gotoxy(33,linha+8);   readln (Cus[idmot].tipo); 
		 repeat   
		  gotoxy(33,linha+8);   readln (Cus[idmot].tipo);
		until (Cus[idmot].tipo='a') or (Cus[idmot].tipo='A') or (Cus[idmot].tipo='b') or (Cus[idmot].tipo='B'); 	           
    gotoxy(62,linha+8);   readln (Cus[idmot].dist);            
    		 if   Cus[idmot].tipo='a' then
		          Cus[idmot].cuscomb:=(Cus[idmot].dist*3.00);
		     
				 if   Cus[idmot].tipo='b' then
		          Cus[idmot].cuscomb:=(Cus[idmot].dist*2.50);
							                                            
    gotoxy(33,linha+9);   readln (Cus[idmot].peso);            
    gotoxy(62,linha+9);   readln (Cus[idmot].cpeso);            
    gotoxy(33,linha+10);  readln (Cus[idmot].adc);               
	  Cus[idmot].total:=(Cus[idmot].dist*Cus[idmot].cuscomb)+(Cus[idmot].peso*(Cus[idmot].cpeso)+Cus[idmot].adc);
		gotoxy(62,linha+10);  writeln('R$',Cus[idmot].total:0:2);                                  
		readkey;
		clrscr;
		gotoxy(30,13); write('CADASTRO CONFIRMADO!!!');
		cadvia:=true;
		totcad:=totcad+1;
		totger:=(totger+Cus[idmot].total);		
    readkey;
	 until (a=1);
	end;
	if (cadm=false)or(cadv=false) then
	 begin
	  gotoxy(25,13); textbackground(black); write('NENHUM MOTORISTA OU VEICULO CADASTRADO!'); textbackground(blue);
	  readkey;
	 end;
end;
		
Procedure Relatorio (cadvia:boolean; num:integer; RetMot:Mot; RetVeic:Veic; Cus:Cust; totcad:integer; totger:real);
var op,ii:integer;
    linha,a:integer;
    flag:string;
    
 begin
  if (cadvia=true) then
	 begin  
      repeat
       a:=1;
       clrscr;           
	 	        Gotoxy(10, 4);  Writeln('**************************************************************');
  	        Gotoxy(10, 5);  Writeln('*                   Menu de Relatórios                       *');
  	        Gotoxy(10, 6);  Writeln('*                                                            *');
   		      Gotoxy(10, 7);  writeln('*             1 - Por Motorista                              *');         
           Gotoxy(10, 8);  Writeln('*             2 - Total da Transportadora                    *');
	    				  Gotoxy(10, 9);  Writeln('*             3 - Voltar                                     *');                    
           Gotoxy(10,10);  Writeln('*                                                            *');
           Gotoxy(10,11);  Writeln('*   Opção:                                                   *');
           Gotoxy(10,12);  Writeln('*                                                            *');
           Gotoxy(10,13);  Writeln('**************************************************************');
           Gotoxy(21,11);  Read(op);
            
       case op of
        1: begin
			      clrscr;
			       Gotoxy(10, 4);       Writeln('**************************************************************');
  	       Gotoxy(10, 5);       Writeln('*                Relatorio por Motoristas                    *');
  	       Gotoxy(10, 6);       Writeln('*                                                            *');
    		    Gotoxy(10, 7);       writeln('*        ID                Nome              Custo           *');
						flag:='relatmot';
						Listagem (num, RetMot, RetVeic, Cus, flag, linha, ii);         
           Gotoxy(10,linha);    Writeln('*                                                            *');                    
           Gotoxy(10,linha+1);  Writeln('**************************************************************');					 					 
					  readkey;
					 end;

		   2:   begin 
		         clrscr;
			       Gotoxy(10, 4);  Writeln('**************************************************************');
  	       Gotoxy(10, 5);  Writeln('*                    Relatório Total                         *');
  	       Gotoxy(10, 6);  Writeln('*                                                            *');
          Gotoxy(10, 7);  writeln('*                 Funcionario com custo:                     *');
		   				 Gotoxy(10, 8);  writeln('*                                                            *'); 
			     	 Gotoxy(10, 9);  writeln('*                   TOTAL de CUSTOS:                         *');       
          Gotoxy(10,10);  Writeln('*                                                            *');
          Gotoxy(10,11);  Writeln('**************************************************************');
				  	 Gotoxy(51, 7);  write(totcad);
						 Gotoxy(47, 9);  write(totger:0:2);
						 readkey;			 						 
						 end; 			
			 end;
			until op = 3;			 	
 end;
 		if (cadvia=false) then
		 begin
	    gotoxy(25,13); textbackground(black); write('NENHUM CUSTO DE VIAGEM CADASTRADO!'); textbackground(blue);
	    readkey;
	   end;			
end;
					
var	RetMot:Mot;
		RetVeic:Veic;
		RetCusto:Cust;
		maxm,maxv,cadm,cadv,inicio,cadvia:boolean;
    op,i,ii:integer;
    totgeral:real;
		totcadast,numm,numv:integer;

begin    
    textbackground(blue);
    clrscr;
    textcolor(white);
		numm:=1;
		numv:=1;
    inicio:=true;
    begin
     if inicio=true then
      begin
       clrscr;  delay(250);
		   gotoxy(35,13); write('INICIANDO'); textbackground(lightgreen); textcolor(lightgreen);			 
			 for i:=1 to 18 do begin
			  gotoxy(30+i,14); delay(50); write('|');	end;	   		   
			 inicio:=false;	 
		   textbackground(blue);
		   textcolor(white);
			 clrscr
		  end;
		end;
	if inicio=false then
	begin	 
		repeat      
       begin
        clrscr;
        Gotoxy(10,4);  Writeln('**************************************************************');
        Gotoxy(10,5);  Writeln('*                    Menu Principal                          *');
        Gotoxy(10,6);  Writeln('*                                                            *');
        Gotoxy(10,7);  Writeln('*              1 - Cadastro de Motorista                     *');
        Gotoxy(10,8);  Writeln('*              2 - Cadastro de Veiculos                      *');
        Gotoxy(10,9);  Writeln('*              3 - Cadastro Custo de Viagem                  *');
        Gotoxy(10,10); Writeln('*              4 - Imprimir Relatorio                        *');
        Gotoxy(10,11); Writeln('*              5 - Sair                                      *');
        Gotoxy(10,12); Writeln('*                                                            *');
        Gotoxy(10,13); Writeln('*   Opção:                                                   *');
        Gotoxy(10,14); Writeln('*                                                            *'); 
        Gotoxy(10,15); Writeln('**************************************************************');
        Gotoxy(21,13); read(Op);
       end;

	   Case op of
	    1: CadMot(Cadm,RetMot,numm,maxm);
	    2: CadVeic(Cadv,numv,RetVeic,maxv);
	    3: CustoViagem(Cadm,Cadv,numm,RetMot,RetVeic,RetCusto,totcadast,Totgeral,cadvia,ii);
	    4: Relatorio(cadvia,numm,RetMot,RetVeic,RetCusto,totcadast,Totgeral);
		 end;
		until op=5;
		 clrscr;  delay(250);
		 gotoxy(32,13); write('FINALIZANDO');
		 i:=0;
		 for i:=1 to 4 do begin
		 gotoxy(43+i,13); delay(300); write('.'); end;
		 exit;
	end;
End.