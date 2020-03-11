"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("react");
var FetchEmployee = /** @class */ (function (_super) {
    __extends(FetchEmployee, _super);
    function FetchEmployee() {
        var _this = _super.call(this) || this;
        _this.state = { empList: [], loading: true };
        // calling  web api method using fetch and setting empList value and loading to false
        fetch('api/Employee/Index')
            .then(function (response) { return response.json(); })
            .then(function (data) {
            _this.setState({ empList: data, loading: false });
        });
        return _this;
    }
    return FetchEmployee;
}(React.Component));
exports.FetchEmployee = FetchEmployee;
var EmployeeData = /** @class */ (function (_super) {
    __extends(EmployeeData, _super);
    function EmployeeData() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.employeeId = 0;
        _this.empnumber = "";
        _this.firstname = "";
        _this.middlename = "";
        _this.lastname = "";
        _this.fullname = "";
        _this.gender = "";
        _this.birthdate = new Date;
        _this.createdate = new Date;
        _this.role = "";
        _this.emailaddress = "";
        _this.ssn = "";
        _this.phone = "";
        _this.address = "";
        _this.city = "";
        _this.postalcode = "";
        return _this;
    }
    return EmployeeData;
}(React.Component));
exports.EmployeeData = EmployeeData;
//# sourceMappingURL=FetchEmployee.js.map