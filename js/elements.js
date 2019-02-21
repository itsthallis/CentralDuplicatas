Vue.component('card', {
   //  props: ['title', 'subtitle'],
   props:{
      title: '',
      subtitle: ''
   },
    template:
    `
    <div class="column">
      <div class="card">
         <div class="card-content has-text-centered">
               <div class="content mt4">
                  <slot name="icon"></slot>
               </div>
         </div>
         <header class="card-header dblock">
            <slot name="image"></slot>
            <p class="card-header-title">{{ title }}</p>
         </header>
         <footer class="card-footer"><p>{{ subtitle }}</p></footer>
      </div>
    </div>
    `
});

Vue.component('infocadastro', {
    template:
    `
         <div class="column mt5 is-4 is-hidden-touch">
               <div>
                  <div class="infoc blue">
                     <div class="columns">
                           <div class="column is-2-desktop dflex1">
                              <i class="fa fa-cube fa-2x"></i>
                           </div>
                           <div class="column is-10-desktop">
                              <span class="titlec">Tenha em mãos seu documento de identidade (RG ou CNH)</span>
                              <br>
                           </div>
                     </div>
                  </div>
                  <div class="infoc">
                     <span class="titlec">Suporte Diário</span>
                     <br>
                     <span class="subtitlec">Time de analistas dedicado a auxiliar em suas operações.</span>
                  </div>
                  <div class="infoc">
                     <span class="titlec">Plataformas Especializadas</span>
                     <br>
                     <span class="subtitlec">As melhores plataformas para diferentes perfis de trader.</span>
                  </div>
                  <div class="infoc">
                     <span class="titlec">Melhor Custo x Benefício</span>
                     <br>
                     <span class="subtitlec">Para o trader que opera frequentemente.</span>
                  </div>
                  <div class="infoc">
                     <span class="titlec">Segurança para Investir</span>
                     <br>
                     <span class="subtitlec">Posições de ativos custodiadas na CLBC e opções com proteção do FGC.</span>
                  </div>
               </div>
      </div>
    `
});

Vue.component('searchbar', {
    template:
    '<div class="column is-12"> <div class="columns dflex3"> <div class="column is-6-tablet"> <div class="columns"> <div class="column is-11"> <input id="searchbar" type="search" placeholder="Pesquisar" /> </div> <div class="column is-1 dflex1"> <span class="icon"><i id="search-btn" class="fa fa-search fa-2x"></i></span> </div> </div> </div> </div> </div>'
});

Vue.component('btnprev', {
    template:
    '<a class="button is-info is-outlined is-pulled-left is-medium"><i class="fa fa-chevron-left"></i>&nbsp;Anterior</a>'
});

Vue.component('btnnext', {
    template:
    '<a class="button is-info is-pulled-right is-medium">Próximo&nbsp;<i class="fa fa-chevron-right"></i></a>'
});

Vue.component('titulocadastro', {
    props: ['title', 'subtitle'],
    template:
    '<div class="mt5"> <h1 class="title">{{title}}</h1> <h2 class="subtitle">{{subtitle}}</h2></div>'
});

Vue.component('radiobtnc', {
    props: ['name','label', 'value', 'id'],
    template:
    '<input class="is-checkradio" {{id}} :value="label" type="radio" :name="name" v-model="radioButtonValue"><label for="">{{ label }}</label>'
});

Vue.component('inputc', {
    props: ['label'],
    template:
    `
    <div class="field">
    <label class="label" for="">{{ label }}</label>
    <div class="control">
       <input id="" name="" placeholder="" class="input">
       </div>
    </div>
    `
});

Vue.component('notificationc', {
    props: ['text'],
    template:
    '<div class="notification is-info"> <i class="fa fa-info-circle"></i>&nbsp;{{ text }}</div>'
});

Vue.component('navbarhome', {
    props: ['text'],
    template:
    `
   <header>
      <nav id="nav" class="navbar scroll is-fixed-top" role="navigation" aria-label="main navigation">
      <div class="container">
      <div class="navbar-brand">
         <a class="navbar-item" href="./../home">
            <img src="/images/logo.png" height="100%">
         </a>

         <a role="button" class="navbar-burger burger" aria-label="menu" aria-expanded="false" data-target="navbarBasicExample">
            <span aria-hidden="true"></span>
            <span aria-hidden="true"></span>
            <span aria-hidden="true"></span>
         </a>
      </div>

      <div id="navbarBasicExample" class="navbar-menu">
         <div class="navbar-end">
            <div class="navbar-item is-centered-touch">
               <div class="buttons is-centered">
                  <a href="/login" class="button is-light">
                     Login
                  </a>
                  <a href="/cadastro" class="button is-info">
                     Começar agora
                  </a>
               </div>
            </div>
         </div>
         </div>
      </div>
      </nav>
   </header>
    `
});

Vue.component('navbarinternal', {
   props: ['text'],
   template:
   `
<header>
   <nav id="nav" class="navbar scroll is-fixed-top" role="navigation" aria-label="main navigation">
    <div class="container">
    
    <div class="navbar-brand">
      <a class="navbar-item" href="./../home">
         <img src="/images/logo.png" alt="" height="100%">
      </a>
      <a role="button" class="navbar-burger burger" aria-label="menu" aria-expanded="false" data-target="navbarBasicExample">
         <span aria-hidden="true"></span>
         <span aria-hidden="true"></span>
         <span aria-hidden="true"></span>
      </a>
    </div>

    <div id="navbarBasicExample" class="navbar-menu">
      <div class="navbar-end">
         <div class="navbar-item has-dropdown is-hoverable">
            <a v-on:mouseover="mouseover" v-on:mouseleave="mouseleave" id="menulink" class="navbar-link is-hidden-touch">
               Menu
            </a>
            <div class="navbar-dropdown">
               <a href="./../Login/" class="navbar-item">
                  Login
               </a>
               <a href="./../Cadastro/" class="navbar-item">
               Cadastro
               </a>
               <a href="./../Dashboard/" class="navbar-item">
               Minha conta
               </a>
            </div>
            </div>
         </div>
      </div>
    </div>

    </div>
   </nav>
</header>
   `,
   methods: {
    mouseover(){
        document.getElementById('#menulink').style.color = "orange";
    },    
    mouseleave(){
        document.getElementById('#menulink').style.color = "blue";
    }
  }
});

Vue.component('audioplayer', {
   template:`
    <div class="fullheight dflex1">
        <div class="column is-4">   
<div class="holder">
   <div class="audio green-audio-player">
     <div class="loading">
       <div class="spinner"></div>
     </div>
     <div class="play-pause-btn">  
       <svg xmlns="http://www.w3.org/2000/svg" width="18" height="24" viewBox="0 0 18 24">
         <path fill="#566574" fill-rule="evenodd" d="M18 12L0 24V0" class="play-pause-icon" id="playPause"/>
       </svg>
     </div>
 
     <div class="controls">
       <span class="current-time">0:00</span>
       <div class="slider" data-direction="horizontal">
         <div class="progress">
           <div class="pin" id="progress-pin" data-method="rewind"></div>
         </div>
       </div>
     </div>
 
     <div class="volume">
       <div class="volume-controls hidden">
         <div class="slider" data-direction="vertical">
           <div class="progress">
             <div class="pin" id="volume-pin" data-method="changeVolume"></div>
           </div>
         </div>
       </div>
     </div>
 
     <audio crossorigin>
       <slot name="audio"></slot>
     </audio>
   </div>
 </div>
 </div>
    </div>
   `
});