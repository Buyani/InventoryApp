  import { Component, OnInit ,ViewChild} from '@angular/core';
  import { Product } from '../product';
  import { Observable } from 'rxjs';
  import { MatPaginator } from '@angular/material/paginator';
  import { MatSort } from '@angular/material/sort';
  import { FormBuilder, Validators } from '@angular/forms';
  import { MatTableDataSource, } from '@angular/material/table';
  import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
  import { ProductService } from '../product.service';
  import { ProductType } from '../product-type';
  import { SelectionModel } from '@angular/cdk/collections';

  @Component({
    selector: 'app-product',
    templateUrl: './product.component.html',
    styleUrls: ['./product.component.scss']
  })
  export class ProductComponent implements OnInit {
    dataSaved = false;
    showModal: boolean;
    submitted = false;
    serverresponse:any;
    allProductTypes: ProductType[];
    selectedProductType: number; 

    productForm:any;
    public columnsToDisplay : string[] =['productPurchaseId','productName' ,'productTypeId', 'quantity', 'unitPrice'];
    public dataSource = new MatTableDataSource<Product>();
    horizontalPosition: MatSnackBarHorizontalPosition = 'center';
    verticalPosition: MatSnackBarVerticalPosition = 'bottom';
    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;
      
  constructor(private formbulider: FormBuilder,private productService: ProductService, private _snackBar: MatSnackBar) { 
    this.productService.getAllProducts().subscribe(data => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }


  ngOnInit():void {
    this.productForm = this.formbulider.group({
      productName: ['', [Validators.required]],
      quantity: ['', [Validators.required]],
      unitPrice: ['', [Validators.required]],
      productTypeId: ['', [Validators.required]]
    });
    this.loadProducts();
    this.loadTypes();
    
  }

  loadProducts(){
    this.productService.getAllProducts().subscribe(data=>{
      this.dataSource=new MatTableDataSource(data);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  loadTypes()
  {
    this.productService.getAllProductTypes().subscribe(data=>{
      this.allProductTypes=data;
      console.log(this.allProductTypes)
    })
  }


  resetForm() {
    this.productForm.reset();
    this.dataSaved=false;
    this.loadProducts();
  }

  onFormSubmit() {
    this.dataSaved = true;
    const product = this.productForm.value;
    this.CreateProduct(product);
    this.SavedSuccessful(1);
  }


  CreateProduct(product: Product) {
    this.productService.createProduct(product).subscribe(response=>{
      this.serverresponse=response;
    })
    this.dataSaved=true;
    this.SavedSuccessful(1);
    this.loadProducts();
    this.productForm.reset();
  }

  SavedSuccessful(isUpdate:any) {
    if (isUpdate == 0) {
      this._snackBar.open('Record Updated Successfully!', 'Close', {
        duration: 8000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    } 
    else if (isUpdate == 1) {
      this._snackBar.open('Record Saved Successfully!', 'Close', {
        duration: 8000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
    else if (isUpdate == 2) {
      this._snackBar.open('Record Deleted Successfully!', 'Close', {
        duration: 8000,
        horizontalPosition: this.horizontalPosition,
        verticalPosition: this.verticalPosition,
      });
    }
  }

  }

