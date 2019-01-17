import java.awt.Color;
import java.awt.Graphics;

public class TruckTrailer {
	private float _startPosX;// Ëåâàÿ êîîðäèíàòà îòðèñîâêè àâòîìîáèëÿ
	private float _startPosY;// Ïðàâàÿ êîîðèäíàòà îòðèñîâêè àâòîìîáèëÿ
	public int _pictureWidth; // Øèðèíà îêíà îòðèñîâêè
	public int _pictureHeight;// Âûñîòà îêíà îòðèñîâêè
	private static final int carWidth = 100;// Øèðèíà îòðèñîâêè àâòîìîáèëÿ
	private static final int carHeight = 60;// Âûñîòà îòðèñîâêè àâòîìîáèëÿ
	private int MaxSpeed; // Ìàêñèìàëüíàÿ ñêîðîñòü

	public int getMaxSpeed() {
		return MaxSpeed;
	}

	public void setMaxSpeed(int value) {
		MaxSpeed = value;
	}

	private float Weight;// Âåñ àâòîìîáèëÿ

	public float getWeight() {
		return Weight;
	}

	public void setWeight(float value) {
		Weight = value;
	}

	private Color MainColor;// Îñíîâíîé öâåò êóçîâà

	public Color getMainColor() {
		return MainColor;
	}

	public void setMainColor(Color value) {
		MainColor = value;
	}

	private Color DopColor;// Äîïîëíèòåëüíûé öâåò

	public Color getDopColor() {
		return DopColor;
	}

	public void setDopColor(Color value) {
		DopColor = value;
	}

	private boolean Cabin;// Ïðèçíàê íàëè÷èÿ êàáèíû

	public boolean getCabin() {
		return Cabin;
	}

	public void setCabin(boolean value) {
		Cabin = value;
	}

	/**
	 * Êîíñòðóêòîð
	 * 
	 * @param maxSpeed
	 *            Ìàêñèìàëüíàÿ ñêîðîñòü
	 * @param weight
	 *            Âåñ àâòîìîáèëÿ
	 * @param mainColor
	 *            Îñíîâíîé öâåò êóçîâà
	 * @param dopColor
	 *            Äîïîëíèòåëüíûé öâåò
	 * @param frontSpoiler
	 *            Ïðèçíàê íàëè÷èÿ ïåðåäíåãî ñïîéëåðà
	 * @param sideSpoiler
	 *            Ïðèçíàê íàëè÷èÿ áîêîâûõ ñïîéëåðîâ
	 * @param backSpoiler
	 *            Ïðèçíàê íàëè÷èÿ çàäíåãî ñïîéëåðà
	 */
	public TruckTrailer(int maxSpeed, float weight, Color mainColor,
			Color dopColor, boolean cabin) throws Exception {
		MaxSpeed = maxSpeed;
		setWeight(weight);
		setMainColor(mainColor);
		setDopColor(dopColor);
		setCabin(cabin);

	}

	/**
	 * Óñòàíîâêà ïîçèöèè àâòîìîáèëÿ
	 * 
	 * @param x
	 *            Êîîðäèíàòà X
	 * @param y
	 *            Êîîðäèíàòà Y
	 * @param width
	 *            Øèðèíà êàðòèíêè
	 * @param height
	 *            Âûñîòà êàðòèíêè
	 */
	public void SetPosition(int x, int y, int width, int height)
			throws Exception {
		_startPosX = x;
		_startPosY = y;
		_pictureWidth = width;
		_pictureHeight = height;
	}

	public void MoveTransport(Direction direction) throws Exception // Èçìåíåíèå
																	// íàïðàâëåíèÿ
																	// ïåðìåùåíèÿ
	{
		float step = getMaxSpeed() * 100 / getWeight();
		switch (direction) {
		// âïðàâî
		case Right:
			if (_startPosX + step < _pictureWidth - carWidth) {
				_startPosX += step;
			}
			break;
		// âëåâî
		case Left:
			if (_startPosX - step > 0) {
				_startPosX -= step;
			}
			break;
		// ââåðõ
		case Up:
			if (_startPosY - step > 0) {
				_startPosY -= step;
			}
			break;
		// âíèç
		case Down:
			if (_startPosY + step < _pictureHeight - carHeight) {
				_startPosY += step;
			}
			break;
		}
	}

	public void DrawTruckTrailer(Graphics g) throws Exception
	{
		 g.setColor(Color.ORANGE);
         g.fillRect( (int)_startPosX + 60, (int)_startPosY + 0, 30, 30);
         g.fillRect((int) _startPosX + 30, (int)_startPosY + 15, 30, 15);
         g.fillRect( (int)_startPosX + 60,(int) _startPosY - 10, 30, 10);
         g.setColor(Color.BLUE);
         g.fillRect( (int)_startPosX + 70, (int)_startPosY + 0, 20, 20);
      
         g.setColor(Color.BLACK);
         g.fillOval( (int)_startPosX + 30,(int) _startPosY + 30, 15, 15);
         g.fillOval( (int)_startPosX + 50, (int)_startPosY + 30, 15, 15);
         g.fillOval( (int)_startPosX + 75,(int) _startPosY + 30, 15, 15);
         g.fillRect( (int)_startPosX + 30, (int)_startPosY + 5, 30, 10);
        
	}
}