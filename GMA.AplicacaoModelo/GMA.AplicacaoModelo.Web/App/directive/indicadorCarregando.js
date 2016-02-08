//http://mandarindrummond.com/articles/angular-global-loading-indicator/index.html

(function () {
    "use strict";
    
    angular.module('AppAplicacaoModelo').directive("indicadorCarregando", IndicadorCarregando);

    function IndicadorCarregando() {
        return {
            restrict: "E",
            replace: 'true',
            template: '<div  style="visibility: hidden"><span class="glyphicon glyphicon-refresh glyphicon-refresh-animate"></span> Carregando... </div>',
            link: function (scope, element, attrs) {
                     scope.$on("carregando-inicio", function (e) {
                        element.css({ "visibility": "visible" });
                    });

                    scope.$on("carregando-fim", function (e) {
                        element.css({ "visibility": "hidden" });
                    });

                  }
              };
     }

}());
