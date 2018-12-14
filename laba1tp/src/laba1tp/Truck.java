package laba1tp;
import java.awt.Color;
import java.awt.Graphics;



 public class Truck {
	/// <summary>
	/// Левая координата отрисовки грузовика
	/// </summary>
	private int _startPosX;
	/// <summary>
	/// Правая кооридната отрисовки грузовика
	/// </summary>
	private int _startPosY;
	/// <summary>
	/// Ширина окна грузовика
	/// </summary>
	private int _pictureWidth;
	// Высота окна грузовика
	private int _pictureHeight;
	/// <summary>
	/// Ширина отрисовки грузовика
	/// </summary>
	private final static int TruckWidth = 100;
	/// <summary>
	/// Высота отрисовки грузовика
	/// </summary>
	private final static int TruckHeight = 60;
	/// <summary>
	/// Максимальная скорость
	private int MaxSpeed;

	public int getMaxSpeed() {
		return MaxSpeed;
	}

	public void setMaxSpeed(int value) {
		MaxSpeed = value;
	}

	/// Вес грузовика
	private float Weight;

	public float getWeight() {
		return Weight;
	}

	public void setWeight(float value) {
		Weight = value;
	}

	/// Основной цвет
	private Color MainColor;

	public Color getMainColor() {
		return MainColor;
	}

	public void setMainColor(Color value) {
		MainColor = value;
	}

	private Color DopColor;

	public Color getDopColor() {
		return DopColor;
	}

	public void setDopColor(Color value) {
		DopColor = value;
	}
    public boolean Tilt;
    public boolean Lamp;

	public Truck(int maxSpeed, float weight, Color mainColor, Color dopColor,boolean tilt, boolean lamp) throws Exception {
		setMaxSpeed(maxSpeed);
		setWeight(weight);
		setMainColor(mainColor);
		setDopColor(dopColor);
		Tilt = tilt;
        Lamp = lamp;

	}

	public void setPosition(int x, int y, int width, int height) throws Exception {
		_startPosX = x;
		_startPosY = y;
		_pictureWidth = width;
		_pictureHeight = height;
	}

	public void moveTruck(Direction direction) throws Exception {
		float step = getMaxSpeed() * 100 / getWeight();
		switch (direction) { /// вправо
		case Right:
			if (_startPosX + step < _pictureWidth - TruckWidth) {
				_startPosX += step;
			}

			break;
		/// влево
		case Left:
			if (_startPosX - step > 5) {
				_startPosX -= step;
			}

			break;
		/// вверх
		case Up:
			if (_startPosY - step > 30) {
				_startPosY -= step;
			}

			break;
		/// вниз
		case Down:
			if (_startPosY + step < _pictureHeight - TruckHeight) {
				_startPosY += step;
			}

			break;
		}
	}

	public void drawTruck(Graphics g) throws Exception {

		 //Brush brOrange = new SolidBrush(Color.ORANGE);
		  g.setColor(Color.ORANGE);
         g.fillRect( _startPosX + 60, _startPosY + 0, 30, 30);
         g.fillRect( _startPosX + 30, _startPosY + 15, 30, 15);
         g.fillRect( _startPosX + 60, _startPosY - 10, 30, 10);
        // Brush brBlue = new SolidBrush(Color.BLUE);
         g.setColor(Color.BLUE);
         g.fillRect( _startPosX + 70, _startPosY + 0, 20, 20);
       //  Brush brBlack = new SolidBrush(Color.BLACK);
        g.setColor(Color.BLACK);
         g.fillOval( _startPosX + 30, _startPosY + 30, 15, 15);
         g.fillOval( _startPosX + 50, _startPosY + 30, 15, 15);
         g.fillOval( _startPosX + 75, _startPosY + 30, 15, 15);
         g.fillRect( _startPosX + 30, _startPosY + 5, 30, 10);
         //Brush brYellow = new SolidBrush(Color.YELLOW);
         g.setColor(Color.YELLOW);
         g.fillRect( _startPosX + 85, _startPosY - 15, 5, 5);
        }
		
	}
 
