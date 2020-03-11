import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';

//
export interface FectchEmployeeDataState {
    empList: EmployeeData[];
    loading: boolean;
}

export class FetchEmployee extends React.Component<RouteComponentProps<{}>, FectchEmployeeDataState> {
    state: { empList: any[]; loading: boolean; };
    setState: any;

    constructor() {
        super();
        this.state = { empList: [], loading: true }
        // calling  web api method using fetch and setting empList value and loading to false
        fetch('api/Employee/Index')
            .then(response => response.json() as Promise<EmployeeData[]>)
            .then(data => {
                this.setState({empList: data, loading: false});
            })
    }
}



export class EmployeeData extends React.Component {
    employeeId: number = 0;
    empnumber: string = "";
    firstname: string = "";
    middlename: string = "";
    lastname: string = "";
    fullname: string = "";
    gender: string = "";
    birthdate: Date = new Date;
    createdate: Date = new Date;
    role: string = "";
    emailaddress: string = "";
    ssn: string = "";
    phone: string = "";
    address: string = "";
    city: string = "";
    postalcode: string = "";
}