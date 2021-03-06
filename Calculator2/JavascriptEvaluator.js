import System;
// For Point();
import System.Drawing;
import System.EventArgs;

import System.Windows;
import System.Windows.Forms;
import Accessibility; // Required.


package JavascriptEvaluator
{
	
	
	//compile with the visual studio developer console with this command: jsc /target:library JavascriptEvaluator.js
	class JavascriptEvaluator
	{
		
		
		public function Evaluate(expr : String) : String
		{
			//JSON2.min.js (to use JSON.stringify(obj)
			var JSON;JSON||(JSON={}),(function(){"use strict";function i(n){return n<10?"0"+n:n}function f(n){return o.lastIndex=0,o.test(n)?'"'+n.replace(o,function(n){var t=s[n];return typeof t=="string"?t:"\\u"+("0000"+n.charCodeAt(0).toString(16)).slice(-4)})+'"':'"'+n+'"'}function r(i,e){var h,l,c,a,v=n,s,o=e[i];o&&typeof o=="object"&&typeof o.toJSON=="function"&&(o=o.toJSON(i)),typeof t=="function"&&(o=t.call(e,i,o));switch(typeof o){case"string":return f(o);case"number":return isFinite(o)?String(o):"null";case"boolean":case"null":return String(o);case"object":if(!o)return"null";n+=u,s=[];if(Object.prototype.toString.apply(o)==="[object Array]"){for(a=o.length,h=0;h<a;h+=1)s[h]=r(h,o)||"null";return c=s.length===0?"[]":n?"[\n"+n+s.join(",\n"+n)+"\n"+v+"]":"["+s.join(",")+"]",n=v,c}if(t&&typeof t=="object")for(a=t.length,h=0;h<a;h+=1)typeof t[h]=="string"&&(l=t[h],c=r(l,o),c&&s.push(f(l)+(n?": ":":")+c));else for(l in o)Object.prototype.hasOwnProperty.call(o,l)&&(c=r(l,o),c&&s.push(f(l)+(n?": ":":")+c));return c=s.length===0?"{}":n?"{\n"+n+s.join(",\n"+n)+"\n"+v+"}":"{"+s.join(",")+"}",n=v,c}}typeof Date.prototype.toJSON!="function"&&(Date.prototype.toJSON=function(){return isFinite(this.valueOf())?this.getUTCFullYear()+"-"+i(this.getUTCMonth()+1)+"-"+i(this.getUTCDate())+"T"+i(this.getUTCHours())+":"+i(this.getUTCMinutes())+":"+i(this.getUTCSeconds())+"Z":null},String.prototype.toJSON=Number.prototype.toJSON=Boolean.prototype.toJSON=function(){return this.valueOf()});var e=/[\u0000\u00ad\u0600-\u0604\u070f\u17b4\u17b5\u200c-\u200f\u2028-\u202f\u2060-\u206f\ufeff\ufff0-\uffff]/g,o=/[\\\"\x00-\x1f\x7f-\x9f\u00ad\u0600-\u0604\u070f\u17b4\u17b5\u200c-\u200f\u2028-\u202f\u2060-\u206f\ufeff\ufff0-\uffff]/g,n,u,s={"\b":"\\b","\t":"\\t","\n":"\\n","\f":"\\f","\r":"\\r",'"':'\\"',"\\":"\\\\"},t;typeof JSON.stringify!="function"&&(JSON.stringify=function(i,f,e){var o;n="",u="";if(typeof e=="number")for(o=0;o<e;o+=1)u+=" ";else typeof e=="string"&&(u=e);t=f;if(f&&typeof f!="function"&&(typeof f!="object"||typeof f.length!="number"))throw new Error("JSON.stringify");return r("",{"":i})}),typeof JSON.parse!="function"&&(JSON.parse=function(n,t){function r(n,i){var f,e,u=n[i];if(u&&typeof u=="object")for(f in u)Object.prototype.hasOwnProperty.call(u,f)&&(e=r(u,f),e!==undefined?u[f]=e:delete u[f]);return t.call(n,i,u)}var i;n=String(n),e.lastIndex=0,e.test(n)&&(n=n.replace(e,function(n){return"\\u"+("0000"+n.charCodeAt(0).toString(16)).slice(-4)}));if(/^[\],:{}\s]*$/.test(n.replace(/\\(?:["\\\/bfnrt]|u[0-9a-fA-F]{4})/g,"@").replace(/"[^"\\\n\r]*"|true|false|null|-?\d+(?:\.\d*)?(?:[eE][+\-]?\d+)?/g,"]").replace(/(?:^|:|,)(?:\s*\[)+/g,"")))return i=eval("("+n+")"),typeof t=="function"?r({"":i},""):i;throw new SyntaxError("JSON.parse");})})()
		
			return eval(expr, "unsafe");
		}
		
		public function Contains(arr, val){
			for(var i in arr){
				if(arr[i] == val) return true;
			}
			return false;
		}
		
		public function ContainsGreater(arr, val){
			for(var i in arr){
				if(arr[i] > val) return true;
			}
			return false;
		}
		
		public function ContainsLesser(arr, val){
			for(var i in arr){
				if(arr[i] < val) return true;
			}
			return false;
		}
		
		public function ContainsGreaterEqual(arr, val){
			for(var i in arr){
				if(arr[i] >= val) return true;
			}
			return false;
		}
		
		public function ContainsLesserEqual(arr, val){
			for(var i in arr){
				if(arr[i] <= val) return true;
			}
			return false;
		}
		
		
		public function IndexOf(arr, b) {
			var c, d, e = arr.length, f = b.length;
			for (c = 0; e > c; c++) {
				for (d = 0; f > d && arr[c + d] == b[d]; d++) ;
				if (d == f) return c;
			}
			return -1;
		}
		
		public function Last(arr){
			if(arr.length > 0){
				return arr[arr.length - 1];
			}
			else
			{
				return undefined;
			}
		}

		public function Max(arr){
			var maxValue = undefined;

			for(var i in arr){

				if(maxValue === undefined || arr[i] > maxValue) maxValue = arr[i];
			}

			return maxValue;
		}
		
		public function Min(arr){
			var minValue = undefined;

			for(var i in arr){

				if(minValue === undefined || arr[i] < minValue) minValue = arr[i];
			}

			return minValue;
		}

		public function Length(arr){
			return arr.length;
		}
		
		public function Join(arr, separator){
			var firstJoined = false;
			var result = "";

			for(var i in arr){
				if(firstJoined){
					result += separator.toString() + arr[i]
				}
				else
				{
					result += arr[i];
				}
				firstJoined = true;
			}

			return result;
		}

	}

}