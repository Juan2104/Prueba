﻿angular.module('TipoPersona.service', [])
    .factory('TipoPersonaService', [
        '$http',
        function ($http) {
            return {
                getTipoPersona: function () {
                    return $http({
                        method: 'GET',
                        url: '/TipoPersona/Get'
                    });
                },
                saveTipoPersona: function (TipoPersonaDTO) {
                    return $http({
                        method: 'POST',
                        url: '/TipoPersona/Post',
                        data: { TipoPersonaDTO: TipoPersonaDTO }
                    });
                },
                editTipoPersona: function (TipoPersonaDTO) {
                    return $http({
                        method: 'POST',
                        url: '/TipoPersona/Update',
                        data: { TipoPersonaDTO: TipoPersonaDTO }
                    });
                },
                deleteTipoPersona: function (TipoPersonaDTO) {
                    return $http({
                        method: 'POST',
                        url: '/TipoPersona/Delete',
                        data: { id: TipoPersonaDTO }
                    });
                },
            };
        }]);

