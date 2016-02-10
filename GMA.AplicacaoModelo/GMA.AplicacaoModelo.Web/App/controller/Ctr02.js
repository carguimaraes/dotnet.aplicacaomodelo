//2016/02
//Autor: Carlos Alberto Luciano Martins Guimarães



(function () {
    "use strict";

    angular.module('AppAplicacaoModelo').controller('Ctr02', Ctr02);
   
    Ctr02.$inject = ['$window'];

    function Ctr02($window)
    {
        var _this = this;
        var lista = [
            { xData:"11" , horario:"22", evento:"33",titulo:"44", duracao:"55", tag:"66"}
        ];
        //http://www.trirand.com/blog/jqgrid/jqgrid.html

        mostrarGuid();

        function mostrarGuid()
        {
            _this.isMostrarGride = true;
            //$('#jqGrid').jqGrid('GridUnload');
            $('#jqGrid').jqGrid();


            $.jgrid.defaults.responsive = true;
            //780

            $("#jqGrid").jqGrid({
                datatype: "local",
                rowNum: 100,
                pager: "#jqGridPager",

                recordtext: "Visão {0} - {1} of {2}",
                emptyrecords: "Sem dados",
                loadtext: "Carregando...",
                pgtext: "Pagina {0} de {1}",

                data: lista,
                height: 253,
                width: 1030,
                colModel: [
                    { label: 'Data', name: 'xData', width: 50, key: true, align: 'center', sortable: false },
                    { label: 'Horario', name: 'horario', width: 50, align: 'center', sortable: false },
                    { label: 'Evento', name: 'evento', width: 110, sortable: false },
                    { label: 'Titulo', name: 'titulo', width: 200, sortable: false },
                    { label: 'Dura&ccedil;&atilde;o', name: 'duracao', width: 50, align: 'center', sortable: false },
                    { label: 'Tag', name: 'tag', width: 20, formatter: grideFormatarCelular, align: 'center', sortable: false }

                ],
                regional: 'pt-br',
                viewrecords: false,
                caption: "",
            });
        }

        function grideFormatarCelular(cellValue, options, rowObject) {
            var conteudo = "";
            if (cellValue == "1") conteudo = '<span class="glyphicon glyphicon-plus" ></span>';
            if (cellValue == "2") conteudo = '<span class="glyphicon glyphicon-pencil" ></span>';
            if (cellValue == "3") conteudo = '<span class="glyphicon glyphicon-resize-horizontal" ></span>';

            return conteudo;
        }
    }
          
         
     

}());
