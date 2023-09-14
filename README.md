
# Torc Order Management System

This API allows you to get a list of available products and place an order of one of them.




## API Reference

### Products
#### Get all products

```http
  GET /api/Product/GetProducts
```


### Orders
#### Get order by Id

```http
  GET /api/Order/GetOrderById/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `long` | **Required**. Id of order |

#### Create Order

```http
  POST /api/Order/Create
```

##### Body
```json
{
  "customerId": 0,
  "productId": 0,
  "productQty": 0
}

```


### Token
#### Create token for authentication

```http
  GET /api/Token/GenerateToken
```


