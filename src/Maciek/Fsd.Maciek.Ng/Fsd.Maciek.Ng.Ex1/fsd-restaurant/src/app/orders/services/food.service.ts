import { Injectable } from '@angular/core';
import { Food, Product } from 'app/orders/models';
import { IProductService } from './IproductService';

@Injectable()
export class FoodService implements IProductService {
    private MockFood = [
        new Food(1, 'Kebab wołowy', 'Turecki kebab z ostrym sosiwem', 9),
        new Food(2, 'Naleśniki z serem', 'Puszyste Pancakes z syropem klonowym', 12),
        new Food(3, 'Omlet', 'Omlet z 2 jajek, banana i płatków owsianych. Smażony na oleju kokosowym', 14),
        new Food(4, 'Jajecznica', 'Jajecznica z 4 jajek', 7),
        new Food(5, 'Pierś z kurczaka z ryżem', 'Pierś z kurczaka smażona soute z ryżem brązowym.', 22),

    ];

    getAllProducts(): Product[] {
        return this.MockFood;
    }
}
