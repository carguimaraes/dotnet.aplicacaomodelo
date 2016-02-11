//2016/02
//Autor: Carlos Alberto Luciano Martins Guimarães

(function () {
    "use strict";

    var app = angular.module('AppAplicacaoModelo', ["ngRoute"]);

    app.config(ConfigRota);
    app.config(ConfigIntercepto);

    app.run(['$templateCache', function ($templateCache) {
        $templateCache.removeAll();
    }]);

  //  ConfigRota.$inject = ['$routeProvider', '$locationProvider'];
  //  ConfigIntercepto.$inject = ['$httpProvider'];

    function ConfigRota ($routeProvider, $locationProvider)
    {
       
        $routeProvider
        .when('/Op1', {
            templateUrl: '/app/view/vw01.html?v=b1',
            controller: 'Ctr01',
            controllerAs: 'Ctr01'
         })
        .when('/Op2', {
            templateUrl: 'app/view/vw02.html?v=b1',
             controller: 'Ctr02',
             controllerAs: 'Ctr02'
          })
        .when('/Op3', {
            templateUrl: 'app/view/vw03.html?v=b11',
            controller: 'Ctr03',
            controllerAs: 'Ctr03'
        })
       .otherwise({ redirectTo: '/' });
            
        $locationProvider.html5Mode(false); //.hashPrefix("");
    } 

    function ConfigIntercepto($httpProvider)
    {
        
        $httpProvider.interceptors.push(function ($q, $rootScope) {
            return                 {
                'request': function (config) {
                    $rootScope.$broadcast('show.fechar');
                    $rootScope.$broadcast('carregando-inicio');
                    return config || $q.when(config);
                }, 
                'response': function (response) {
                    $rootScope.$broadcast('carregando-fim');

                   return response || $q.when(response);
                },
                'responseError': function (response) {
                    $rootScope.$broadcast('carregando-fim');
                
                    var listaMsg = response.data;
                                                          
                    if (listaMsg == undefined)
                    {
                        listaMsg = [response.statusText];
                    }

                    response.data = { statusCode: response.status, listaMensagem: listaMsg }

                
                    $rootScope.$broadcast('show.msg', listaMsg);
                    
                    return $q.reject(response);
                   
                },
                'requestError': function (response) {
                    $rootScope.$broadcast('carregando-fim');
                    return response || $q.when(response);
                },
                
            };
        });

    }


}());


 