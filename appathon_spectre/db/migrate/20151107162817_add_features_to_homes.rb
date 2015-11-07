class AddFeaturesToHomes < ActiveRecord::Migration
  def change
    add_column :homes, :size, :integer
    add_column :homes, :number_of_bathrooms, :integer
    add_column :homes, :number_of_bedrooms, :integer
    add_column :homes, :parking_lot, :string
    add_column :homes, :lot_size, :integer
    add_column :homes, :property_type, :string
    add_column :homes, :year_built, :integer
    add_column :homes, :kitchen, :string
		add_column :homes, :bathroom, :string
    add_column :homes, :traffic_connection, :string
    add_column :homes, :street, :string
    add_column :homes, :city, :string
    add_column :homes, :country, :string
    add_column :homes, :side_costs, :string
  end
end
