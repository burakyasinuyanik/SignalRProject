namespace SignalRWebUi.Dtos.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImgUrl { get; set; }
        public bool Status { get; set; }
    }
}
