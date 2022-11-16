var j = "10,20,30,40".split(',');

//var test = [0,2,3,4,5,6,7,8,9,10,20,30,40,50,60,70,80,90,100].shuffle();

function splitClipboard(splitCharacter){
    return Clipboard.GetText().split(splitCharacter);
}


var blabla = [10, 20, [30, 40, [50, 60]]];
var k      = [30, 50];

function fun(){
    return ('b' + 'a' + + 'a' + 'a').toLowerCase()
}

function ResistorOhm(voltage, ampere){
    return voltage / ampere;
}


function CaptureSelection(){
    //MessageBox.Show("what");
    var t = importNamespace('Toolbox.Logging');
    //var logging = t.importNamespace('Logging');
    
    
    //var Logging = importNamespace('Toolbox.Logging');
    MessageBox.Show(t.ApplicationLog.GetSystemTimeMS()); //.Logging
    
    //MessageBox.Show(t.GetSystemTimeMS());
    //return Logging.ApplicationLog.GetSystemTimeMS();
    //Form.FastResult.SelectionChanged += changed;
}

function changed(a, b){
    MessageBox.Show("what");
    Form.FastCalculation.Text = a.SelectedText;
}

function SetFormBackgroundColor(){
    //Form.BackColor = color.FromArgb(10,255,10);
    var what       = "";

    for(var i = 0; i < Form.Controls.Count; i++)
    {
        what += Form.Controls[i].Name + " ";
    }
    return what;
}

