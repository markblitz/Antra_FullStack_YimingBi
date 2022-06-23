export interface ProductRequest{
    id:number,
    name:string,
    supplierId:number,
    categoryId:number,
    quantityPerUnit:string,
    unitPrice:number,
    unitInStock:number,
    unitsOnOrder:number,
    reorderLevel:number,
    discontinued:boolean
}