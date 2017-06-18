import { Product } from "app/orders";

export interface IProductSource {
  getAll(): Product[];
}