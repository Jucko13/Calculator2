var j = "10,20,30,40".split(',');

//var test = [0,2,3,4,5,6,7,8,9,10,20,30,40,50,60,70,80,90,100].shuffle();

function splitClipboard(splitCharacter){
    return Clipboard.GetText().split(splitCharacter);
}


var i = [10, 20];
var k = [30, 50];

function timeDifference(time1, time2){ //timeDifference("22:11:22", "05:33:44") = "16:37:38"
    var timespan = new Date(time1) - new Date(time2);
    return (timespan < TimeSpan.Zero ? '-' : '') + timespan.toString("hh\\:mm\\:ss");
}


function getplctime(inputtime){
    var hundredsSeconds = (inputtime & 0xff); //1/100th of a second
    var seconds         = ((inputtime >> 8) & 0xff);
    var minutes         = ((inputtime >> 16) & 0xff);
    var hours           = ((inputtime >> 24) & 0xff);
    
    return hours + ":" + minutes + ":" + seconds + "." + hundredsSeconds;
}
