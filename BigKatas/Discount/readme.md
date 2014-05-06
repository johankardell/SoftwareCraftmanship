#Rabatt (Varukorg)
Allt enligt strukturen "Kunden har tänkt"...
Rabatter är ett ämne som
lätt kan bli väldigt komplicerat. Tanken med denna kata är att utföra den i steg och att man med hjälp av tester som stöd vågar lägga till
fler features och dels få nya features att funka men även notera att
gamla features funkar alternativt behöver skrivas om. 

###3 för 2

- Samma typ?<br>
- Olika typer?<br>
- Vilken är gratis?<br>

###Sommarrea

- Tänk sommar/påsk/jul<br>
Tän er att det finns en dateTimeService.getDate()
som ger systemets tid och och datum 

###Frakt

- Fri frakt vid belopp över 400 kronor
- Fri frakt vid köp av 2 kläder och 2 skivor

##30 minuter senare...
###Lagerrensning
Alla varor som det finns 10 eller mindre av i lagret 
ger 50% rabatt. Tänk er att det finns en storageService
som det går att läsa av lagret med

- Ex int storageService.stockQuantity(int articleId);


###Kategorirea<br>
- Kategorier (Kläder)<br>
Olika rea på olika kategorier
- Subkategorier (Strumpor)<br>
Ex kläder är på 40% rabatt men strumpor är på 10% rabatt<br/>
Är det största rabatten som gäller eller sammanlagda?
- Premiumkund, brons, silver, guld<br>
Olika nivåer på kunder bör ha olika fördelar. <br/>
bronskunder har 10% rea <br/>
silverkunder har 15 % rea <br/>
guldkunder har 20% rabatt och alltid fri frakt.



Dimensioner<br>
	Datum<br>
	Typ<br>
	Färg<br>
	Pris<br>
	Vikt<br>