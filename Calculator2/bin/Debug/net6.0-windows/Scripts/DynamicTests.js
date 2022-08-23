var r   = 4;
var aT  = (Math.sqrt(3)/2)*r*(r/2);
var aC  = Math.PI * r**2;
var aCP = aC /6;
var aS  = aCP-aT;


var j = "10,20,30,40".split(',');

//var test = [0,2,3,4,5,6,7,8,9,10,20,30,40,50,60,70,80,90,100].shuffle();

function bla2(){
    return Clipboard.GetText().split(',');
    
}


var i = [10, 20];
var k = [30, 50];



function getplctime(inputtime){
    var hundredsSeconds = (inputtime & 0xff); //1/100th of a second
    var seconds         = ((inputtime >> 8) & 0xff);
    var minutes         = ((inputtime >> 16) & 0xff);
    var hours           = ((inputtime >> 24) & 0xff);
    
    return hours + ":" + minutes + ":" + seconds + "." + hundredsSeconds;
}
