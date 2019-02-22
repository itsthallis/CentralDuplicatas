new Vue({
	el:'#cadastroadministrador',
	data: {
		check: [],
		modal:false,
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