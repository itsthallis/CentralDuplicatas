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
		step:1,
		fisica: true,
		dados: {
			telephones:[{ddd: '', telephone: ''}],
			emails: {},
			entity:{},
			userInfoModel:{
				address: {},
			},
		}
	},
	methods:{
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
