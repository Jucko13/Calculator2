
function SetFormBackgroundColor(){
    //Form.BackColor = color.FromArgb(10,255,10);
    var what       = "";

    for(var i = 0; i < Form.Controls.Count; i++)
    {
        what += Form.Controls[i].Name + " ";
    }
    return what;
}


//var color = importNamespace("System.Drawing.Color");

function pickColor(initialColor){
    colorPicker.Color         = initialColor ?? colorPicker.Color;
    colorPicker.AllowFullOpen = true;
    colorPicker.AnyColor      = true;
    colorPicker.FullOpen      = true;
    colorPicker.ShowDialog();
    
    var colorVariants = "Color.FromArgb(" + colorPicker.Color.R + ", " + colorPicker.Color.G + ", " + colorPicker.Color.B + ");";
    colorVariants += " | " + rgbToHex(colorPicker.Color.R,colorPicker.Color.G,colorPicker.Color.B);
    colorVariants += " | " + colorPicker.Color.R + "; " + colorPicker.Color.G + "; " + colorPicker.Color.B;
    
    return colorVariants;
}

function LogB(base, log){
    return Math.log(log) / Math.log(base);
}

function radToDeg(angle){
    return angle / Math.PI * 180;
}

function degToRad(angle){
    return angle / 180 * Math.PI;
}

function rgbToHex(r, g, b){
    return "#" + r.toString(16).padStart(2, '0') + g.toString(16).padStart(2, '0') + b.toString(16).padStart(2, '0');
}


Array.prototype.lengthNotNull = function(){
    return this.length > 0;
};

Array.prototype.average = function(){
    return this.sum() / this.length;
};

Array.prototype.sum = function(){
    return this.reduce( ( p, c ) => +p + +c, 0 );
};

Array.prototype.min = function(){
    return this.reduce( ( p, c ) => Math.min(p,c));
};

Array.prototype.max = function(){
    return this.reduce( ( p, c ) => Math.max(p,c));
};

Array.prototype.hex = function(padding = 0, prefix = ""){
return this.map(x => prefix + x.toString(16).padStart(padding, 0));
};

//https://stackoverflow.com/questions/2450954/how-to-randomize-shuffle-a-javascript-array
Array.prototype.shuffle = function(b,c,d){//placeholder,placeholder,placeholder
    c = this.length;
    while(c)b=Math.random()*c--|0,d=this[c],this[c]=this[b],this[b]=d
    return this;
}

