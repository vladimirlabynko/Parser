# Parser
Test task 

Develop a program that parses strings in this format:
#TP#DATA\r\n
where # is separator character,TP is packet type
DATA is data field of the packet.
\r\n - end of packet sign (line feed and carriage return).
The content of the DATA field depends on the package type.The program must correctly process any incoming strings in a given format, correctly parse them into their components, prepare them for writing to the database (reduce them to the appropriate data types) and simply display the components on the screen.

Description of available package types: 
1. SD package. The DATA field contains the following fields:
#SD#date;time;lat1;lat2;lon1;lon2;speed;course;height;sats\r\n 
Example: #SD#04012011;135515;5544.6025;N;03739. 6834;E;35;215;110;7 
Field description: date - date in DDMMYYYY format, in UTC time - time in HHMMSS format, in UTC 
lat1;lat2 - latitude (5544.6025;N) - convert to one fractional number 
lon1;lon2 - longitude (03739. 6834;E) - to convert to one fractional number
speed - speed, integer, km/h 
course - course, integer, 
degrees height, integer, 
meters sats - number of satellites, integer 

2. Package "M". Field DATA contains one text field with a message. 
Package example: #M#груздоставлен
