// TODO: Need to move this url.
let urlRootApi = 'http://localhost:55205/api';
var records;

$(function () {
    Interface.initUI();
});

let Interface = (function () {
    return {
        initUI: function () {
            Interface.EventsAdd();
        },
        EventsAdd: function () {
            $('#btnSearch').click(function () {
                BLL.callEmployee();
            });
        }
    }
})();

let BLL = (function () {
    return {
        callEmployee: function () {
            let idEmployee = $("#idEmployee").val();

            if (idEmployee == '') {
                idEmployee = -1;
            }

            let urlRootApi = `/employee/${idEmployee}`;
            Services.callApi(urlRootApi, "GET", BLL.salaryEmployee, BLL.salaryEmployeeError);
        },
        salaryEmployee: function (data) {
            records = data;
            console.log(records);

            $("#jsGrid").jsGrid({
                width: "100%",
                height: "200px",

                inserting: false,
                editing: false,
                sorting: false,
                paging: false,

                data: records,

                fields: [
                    //{ type: "control" },
                    { name: "id", type: "text", width: 150 },
                    { name: "name", type: "text", width: 150 },
                    { name: "contractTypeName", type: "text", width: 150 },
                    { name: "roleName", type: "text", width: 150 },
                    { name: "AnualSalary", type: "text", width: 150 }

                ]
            });

        },
        salaryEmployeeError: function () {
            //TODO: Need to control the exceptions.
            console.log("error Conn!");
        }

    }
})();

let Services = (function () {
    return {
        initUI: function () {

        },
        callApi: function (urlApi, typeCall, functionApi, functionErrorApi) {

            $.ajax({
                url: urlRootApi + urlApi,
                type: typeCall,
                dataType: 'json',
                success: function (data) {
                    functionApi(data);
                },
                error: function () {
                    functionErrorApi();
                }
            });
        }
    }
})();




