﻿# Tehtävä 10

1. Lataa autokaupan-tietokanta-5000.sql tiedosto. Tiedosto on dump File MsSQL palvelimesta ja saat tuotua sen 
Visual Studion Micrososft SQL serveriin. Luo ensin paikalliseen tietokantaan uusi tietokanta nimeltä Autokauppa. 
Avaa tämän jälkeen dump file ja suorita se, Visual Studio pyytää sitomaan sql komennon oikeaan tietokantaan, jos
onnistut tietokantaan syntyy uudet taulut ja populoidaan testi datalla.	

2. Tutki tietokannan rakennetta, niiden tauluja ja selaa millaisia tietoja sieltä löytyy.

3. Katso Auto-taulua ja sen rakennetta. 

4. Luo sen pohjalta Auto.cs-tiedostoon Attribuutit (nimi ja tietotyyppi)
	- Tietotyypin voi päätellä katsomalla tietokannan kentän tietotyyppi, eli jos tietokannassa
	  on int-tyyppinen, voi se olla myös luokassa int.
	
5. Generoi lopuksi jokaiselle attribuutille get ja set-Funktiot
	- Katso ohjeet OneNoten ohje: get ja set-metodit miten säästyt koodin kirjoittamiselta :)

Vinkit:

- Attribuutteja on oltava yhtä monta kuin tietokannan sarakkeita.
- Päivämäärä voi olla tietotyyppiä: DateTime
- Desimaaliluvut voivat olla tietotyyppiä: Decimal

