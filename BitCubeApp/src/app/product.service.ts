import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from './product';
import { ProductType } from './product-type';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  url="http://localhost:59740/api/"
  constructor(public http:HttpClient) { }

  getAllProducts():Observable<Product[]>{
    return this.http.get<Product[]>(this.url+'ProductPurchase')
  }

  createProduct(product:any){
   return this.http.post(this.url+'ProductPurchase',product);  
  }


  updateProduct(product:Product):Observable<Product>{
    const httpOptions={headers:new HttpHeaders({'Content-Type':'application/json'})};
    return this.http.put<Product>(this.url+'ProductPurchase',product,httpOptions);
  }


  //Product Type Methods
  getAllProductTypes(){
    return this.http.get<ProductType[]>(this.url+'ProductType');
  }
  getType(TypeId: string): Observable<ProductType[]> {
    return this.http.get<ProductType[]>(this.url + 'ProductType/'+ TypeId);
  }

  createProductTypes(product_type:ProductType):Observable<ProductType>{
    const httpOptions={headers:new HttpHeaders({'Content-Type':'application/json'})};
    return this.http.post<ProductType>(this.url+'ProductPurchase/',product_type,httpOptions);
  }
}


