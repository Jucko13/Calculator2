//var color = importNamespace("System.Drawing.Color");

Array.prototype.lengthNotNull = function() {
    return this.length > 0;
};

Array.prototype.average = function(func) {
    return this.sum(func) / this.length;
};

Array.prototype.median = function(func) {
    func = func || function(x) { return x; };
    
    const sorted = Array.from(this).map(func).sort((a, b) => a - b);
    const middle = Math.floor(sorted.length / 2);

    if (sorted.length % 2 === 0) {
        return (sorted[middle - 1] + sorted[middle]) / 2;
    }

    return sorted[middle];
};

Array.prototype.sum = function(func) {
    func = func || function(x) { return x; };
    return this.map(func).reduce( ( p, c ) => +p + +c, 0);
};

Array.prototype.min = function(func) {
    func = func || function(x) { return x; };
    return this.map(func).reduce( ( p, c ) => Math.min(p,c));
};

Array.prototype.max = function(func) {
    func = func || function(x) { return x; };
    return this.map(func).reduce( ( p, c ) => Math.max(p,c));
};

Array.prototype.hex = function(padding = 0, prefix = "", suffix = "") {
    return this.map(x => prefix + x.toString(16).padStart(padding, 0) + suffix);
};

//https://stackoverflow.com/questions/2450954/how-to-randomize-shuffle-a-javascript-array
Array.prototype.shuffle = function(b,c,d){//placeholder,placeholder,placeholder
    c = this.length;
    while(c)b=Math.random()*c--|0,d=this[c],this[c]=this[b],this[b]=d
    return this;
};


String.prototype.scrambleLetterCase = function() { //Spongebob meme letter case: lIkE tHiS
    var offset = 0;
    return Array.from(this.toLowerCase()).map((x,i) => {
        var charCode = x.charCodeAt();
        if(!(charCode >= 65 && charCode <= 127)) offset--;
        return (i + offset) % 2 == 1 ? x.toUpperCase() : x;
    }).join("");
};

String.prototype.scrambleLettersInWords = function() { //first and last char in every word stays, the rest gets scrambled within the words
    return this.split(' ').map(x => {
        if(x.length < 4) return x;
        var wholeWord = x.split('');
        
        return wholeWord[0] + wholeWord.slice(1,-1).shuffle().join('') + wholeWord[wholeWord.length -1];
    }).join(' ');
}
