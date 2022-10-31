var j = "10,20,30,40".split(',');

//var test = [0,2,3,4,5,6,7,8,9,10,20,30,40,50,60,70,80,90,100].shuffle();

function splitClipboard(splitCharacter){
    return Clipboard.GetText().split(splitCharacter);
}


var i = [10, 20, [30, 40, [50, 60]]];
var k = [30, 50];

function fun(){
    return ('b' + 'a' + + 'a' + 'a').toLowerCase()
}

function Lasal()
{
    var res = Clipboard.GetText().substring(3).replace(/[A-Z]/g, ' $&').trim().toLowerCase();
    res     = res.charAt(0).toUpperCase() + res.substring(1);
    Clipboard.Clear();
    Clipboard.SetText(res);
    return res;
}

function CaptureSelection(){
    //MessageBox.Show("what");
    var ToolBox = importNamespace('Toolbox');
    var Logging = importNamespace('Toolbox.Logging');
    var Log     = new Logging.ApplicationLog();
    
    MessageBox.Show(Log.GetSystemTimeMS());
    return Logging.ApplicationLog.GetSystemTimeMS();
    //Form.FastResult.SelectionChanged += changed;
}

function changed(a, b){
    MessageBox.Show("what");
    Form.FastCalculation.Text = a.SelectedText;
}