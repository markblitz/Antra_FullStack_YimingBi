export interface EmployeeRequest{
    id:number,
    firstName:string,
    lastName:string,
    title:string,
    titleOfCourtesy:string,
    birthDate:Date,
    hireDate:Date,
    address:string,
    city:string,
    regionId:number,
    postalCode:string,
    country:string,
    phone:string,
    reportsTo:number,
    photoPath:string
}