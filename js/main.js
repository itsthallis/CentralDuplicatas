new Vue({
	el: '#main'
});

new Vue({
	el: '#dash'
});

new Vue({
	el: '#home'
});

new Vue({
	el: '#login'
});

new Vue({
	el: '#xmlimport'
});

new Vue({
	el: '#comofunciona'
});

new Vue({
	el: '#termos',
	data: {
		termoschecked: true
	}
});

const app = new Vue({
	el:'#cad',
	data: {
		cep: null,
        data: null,
        message: null,
		step:1,
		fisica: true,
		dados: {
			telephones:[{
				ddd:'',
				number:''
			}],
			emails: {},
			entity:{},
			userInfoModel:{
				address: {
					postcode:'',
					city: '',
					state: '',
					thoroughfare: '',
					number:'',
					neighborhood:'',
					complement:''


				},
			},
		},
		modalTermosActive: false
	},
	methods:{
		addLoading() {
			document.querySelector('.control').classList.add('is-loading')
	},
	removeLoading() {
		document.querySelector('.control').classList.remove('is-loading')
	},
	searchCep() {


		if (this.cep.length == 8) {

			this.addLoading()

			axios
			.get(`https://viacep.com.br/ws/${ this.cep }/json/`)
			.then((resp) => {
				this.removeLoading()
				
				if(resp.data.erro == true) {
					this.data = null
					this.message = 'Cep não encontrado.'
					this.cep = null
				}
				else {
					this.data = resp.data
					this.dados.userInfoModel.address.postcode = resp.data.cep
					this.dados.userInfoModel.address.city = resp.data.localidade
					this.dados.userInfoModel.address.state = resp.data.uf
					this.dados.userInfoModel.address.thoroughfare = resp.data.logradouro
					this.dados.userInfoModel.address.number = resp.data.numero
					this.dados.userInfoModel.address.neighborhood = resp.data.bairro
					this.dados.userInfoModel.address.complement = resp.data.complemento


					this.message = null
				}
			})
			.catch((err) => {
				this.data = null
			})

		}
		else {
			if(this.cep == '' || this.cep > 8 || this.cep < 8) {
				this.data = null
			} 
		}
	},


		addUser: function () { console.log("fdsfs")
			this.dados.telephones.push({ ddd: '',number:'' });
		  },
		  deleteUser: function (index) {
			console.log(index);
			console.log(this.finds);
			this.dados.telephones.splice(index, 1);
			if(index===0)
			this.addUser()
		  },
		
	  
	  prev: function() {
		this.step--;
	  },
	  next:function() {
		this.step++;
	  },
	  submit:function() {

		var config = {
			headers: { 
				'Content-Type': 'application/json',
				'Authorization' : 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6IjlmODU5ODc4LTE1MDMtNDdiMS04YWJjLWZiNzliZGUwNTA1YyIsIm5iZiI6MTU0OTY0NDUxMCwiZXhwIjoxNTQ5NjQ4MTEwLCJpYXQiOjE1NDk2NDQ1MTB9.IcyTXSI3CRCLc6MwcBu-7cgq2BN-4rmIFbG4GjjeqeE',
				'UAuthorization': 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyIwNTQzNDE2MDk3NSIsIjA1NDM0MTYwOTc1Il0sImp0aSI6IjZhZDBmYWFlLWU1YjMtNDBlZi1hZGMzLTc1YzU1NGI1ZTQ3YSIsIm5iZiI6MTU0OTY0NDU0NCwiZXhwIjoxNTgxMTgwNTQ0LCJpYXQiOjE1NDk2NDQ1NDR9.SCRpFdvaazzbSLDeBZ-Des48eWQ33zNA_2igQMUjuUw'
			},
		  };

		  console.log(this.dados);
		axios.post('https://ieptb-api.azurewebsites.net/api/0.01/members/saveuser', this.dados, config)
		.then(response => {
	
			alert("Cadastro efetuado com sucesso!!!");
			
		})
	}

	}
  });

//  Auto hide navbar ///////////////////////////////////////////////

function SlidingHeader(options) {
this.init(options);
}

SlidingHeader.prototype.init = function(options) {
// Define the settings as an object
var settings = {
	element: options.element,
	class: 'to_scroll'
}

// If the target element has a specific class declared in the object passed,
// replace the default class key in settings object
if (options.class) {
	settings.class = options.class;
}

// Get the target element from the DOM
var elementToSlide = document.querySelector(settings.element);

// If there's a valid element, slide it. If not, just return false
if (elementToSlide != null) {
	var elementSettings = {
		elementHeight: elementToSlide.clientHeight,
		class: settings.class
	}

	this.slide(elementToSlide, elementSettings);
} else {
	return false;
}
}

SlidingHeader.prototype.slide = function(element, elementSettings) {

var offset = 0,
	lastPosition = 0,
	targetClass = elementSettings.class,
	elementHeight = elementSettings.elementHeight;

window.addEventListener('scroll', function(e) {

	var newPosition = this.scrollY,
		position = newPosition - lastPosition;

	// If we scrolled more than the element's height, then add the class to it.
	// Else, remove it, and the element will show up again
	if (offset + position > elementHeight) {
		offset = elementHeight;

		if (!element.classList.contains(targetClass)) {
			element.className = element.className + targetClass;
		}
	} else {
		offset = offset + position;

		if (element.classList.contains(targetClass)) {
			element.className = '';
		}
	}

	if (offset < 0) {
		offset = 0;
	}

	lastPosition = newPosition;

});
};

var slidingHeader = new SlidingHeader({
element: 'header',
class: 'scrolled'
});

//  Smooth Scroll on click ///////////////////////////////////////////////

function ScrollDown() {
var elmnt = document.getElementById("tiles");
elmnt.scrollIntoView({ block: 'start',  behavior: 'smooth' });
};


//  Searchbar ///////////////////////////////////////////////

function myFunction() {
	var input, filter, ul, li, a, i, txtValue;
	input = document.getElementById("searchbar");
	filter = input.value.toUpperCase();
	ul = document.getElementById("columns");
	li = ul.getElementsByTagName("column");
	for (i = 0; i < li.length; i++) {
			a = li[i].getElementsByTagName("card")[0];
			txtValue = a.textContent || a.innerText;
			if (txtValue.toUpperCase().indexOf(filter) > -1) {
					li[i].style.display = "";
			} else {
					li[i].style.display = "none";
			}
	}
}

//  Change navbar color on scroll ///////////////////////////////////////////////

//   var body = document.body;
//   var html = document.documentElement;

//   var myNav = document.getElementById("nav");

//   window.onscroll = function() {
// 	"use strict";
// 	if (document.body.scrollTop >= 270 || document.documentElement.scrollTop >= 280) {
// 	  myNav.classList.add("scroll");
// 	} else {
// 	  myNav.classList.remove("scroll");
// 	}
//   };

var $jscomp={scope:{}};$jscomp.defineProperty="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(c.get||c.set)throw new TypeError("ES3 does not support getters and setters.");a!=Array.prototype&&a!=Object.prototype&&(a[b]=c.value)};$jscomp.getGlobal=function(a){return"undefined"!=typeof window&&window===a?a:"undefined"!=typeof global&&null!=global?global:a};$jscomp.global=$jscomp.getGlobal(this);$jscomp.SYMBOL_PREFIX="jscomp_symbol_";
$jscomp.initSymbol=function(){$jscomp.initSymbol=function(){};$jscomp.global.Symbol||($jscomp.global.Symbol=$jscomp.Symbol)};$jscomp.symbolCounter_=0;$jscomp.Symbol=function(a){return $jscomp.SYMBOL_PREFIX+(a||"")+$jscomp.symbolCounter_++};
$jscomp.initSymbolIterator=function(){$jscomp.initSymbol();var a=$jscomp.global.Symbol.iterator;a||(a=$jscomp.global.Symbol.iterator=$jscomp.global.Symbol("iterator"));"function"!=typeof Array.prototype[a]&&$jscomp.defineProperty(Array.prototype,a,{configurable:!0,writable:!0,value:function(){return $jscomp.arrayIterator(this)}});$jscomp.initSymbolIterator=function(){}};$jscomp.arrayIterator=function(a){var b=0;return $jscomp.iteratorPrototype(function(){return b<a.length?{done:!1,value:a[b++]}:{done:!0}})};
$jscomp.iteratorPrototype=function(a){$jscomp.initSymbolIterator();a={next:a};a[$jscomp.global.Symbol.iterator]=function(){return this};return a};$jscomp.polyfill=function(a,b,c,d){if(b){c=$jscomp.global;a=a.split(".");for(d=0;d<a.length-1;d++){var f=a[d];f in c||(c[f]={});c=c[f]}a=a[a.length-1];d=c[a];b=b(d);b!=d&&null!=b&&$jscomp.defineProperty(c,a,{configurable:!0,writable:!0,value:b})}};
$jscomp.polyfill("Array.from",function(a){return a?a:function(a,c,d){$jscomp.initSymbolIterator();c=null!=c?c:function(a){return a};var b=[],e=a[Symbol.iterator];if("function"==typeof e)for(a=e.call(a);!(e=a.next()).done;)b.push(c.call(d,e.value));else for(var e=a.length,g=0;g<e;g++)b.push(c.call(d,a[g]));return b}},"es6-impl","es3");var MOUSE_EVENTS=["click","touchstart"],Carousel=function(a){this.element=a;this.init()};
Carousel.prototype.init=function(){var a=this;this.items=Array.from(this.element.querySelectorAll(".carousel-item"));MOUSE_EVENTS.forEach(function(b){var c=a.element.querySelector(".carousel-nav-left"),d=a.element.querySelector(".carousel-nav-right");c&&c.addEventListener(b,function(b){b.preventDefault();a.move("previous");a.autoplayInterval&&(clearInterval(a.autoplayInterval),a.autoPlay(a.element.dataset.delay||5E3))},!1);d&&d.addEventListener(b,function(b){b.preventDefault();a.move("next");a.autoplayInterval&&
(clearInterval(a.autoplayInterval),a.autoPlay(a.element.dataset.delay||5E3))},!1)});this.initOrder();this.element.dataset.autoplay&&"true"==this.element.dataset.autoplay&&this.autoPlay(this.element.dataset.delay||5E3)};Carousel.prototype.initOrder=function(){var a=this.element.querySelector(".carousel-item.is-active");(a=this.items.indexOf(a))?this.items.push(this.items.splice(0,a)):this.items.unshift(this.items.pop());this.setOrder()};
Carousel.prototype.setOrder=function(){this.items.forEach(function(a,b){a.style["z-index"]=1!==b?"0":"1";a.style.order=b})};
Carousel.prototype.move=function(a){a=void 0===a?"next":a;var b=this;this.items.length&&(this.element.querySelector(".carousel-item.is-active").classList.remove("is-active"),"previous"===a?(this.items.unshift(this.items.pop()),this.element.classList.add("is-reversing")):(this.items.push(this.items.shift()),this.element.classList.remove("is-reversing")),(1<=this.items.length?this.items[1]:this.items[0]).classList.add("is-active"),this.setOrder(),this.element.classList.toggle("carousel-animated"),setTimeout(function(){b.element.classList.toggle("carousel-animated")},
50))};Carousel.prototype.autoPlay=function(a){var b=this;this.autoplayInterval=setInterval(function(){b.move("next")},void 0===a?5E3:a)};document.addEventListener("DOMContentLoaded",function(){var a=document.querySelectorAll(".carousel, .hero-carousel");[].forEach.call(a,function(a){new Carousel(a)})});

