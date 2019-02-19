new Vue({
	el:'#cadastrousuarios',
    data: {
        users: [{ cpf: '',
        nome:'',
        celular:'',
        email:'',
        confirmaremail:''  }] 
        
      },
      methods: {
        addUser: function () {
          this.users.push({ cpf: '',nome:'',celular:'', email:'',confirmaremail:'' });
        },
        deleteUser: function (index) {
          console.log(index);
          console.log(this.finds);
          this.users.splice(index, 1);
          if(index===0)
          this.addUser()
        }
      }
    });