using System.Net.Http;
using Vimeo.Api;
using Vimeo.Core;
using Vimeo.Core.Logging;
using Vimeo.Core.Models;

namespace Vimeo;

/// <summary>
/// Build something great. Vimeo's API supports flexible, high-quality video integration with your custom apps.
/// </summary>
public sealed class VimeoClient
{
    public VimeoClient(HttpClient httpClient, VimeoClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "VimeoClient/3.4.9 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "3.4.9"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "VimeoClient");
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        var auth = new AuthSchemes(options, server, rawClient, urlFactory);
        ApiAppsWebhooks = new ApiAppsWebhooks(rawClient, server, auth);
        ApiInformationEssentials = new ApiInformationEssentials(rawClient, server, auth);
        AuthenticationExtrasAuthenticate = new AuthenticationExtrasAuthenticate(rawClient, server, auth);
        AuthenticationExtrasConvert = new AuthenticationExtrasConvert(rawClient, server, auth);
        AuthenticationExtrasEssentials = new AuthenticationExtrasEssentials(rawClient, server, auth);
        AuthenticationExtrasExchange = new AuthenticationExtrasExchange(rawClient, server, auth);
        CategoriesChannels = new CategoriesChannels(rawClient, server, auth);
        CategoriesEssentials = new CategoriesEssentials(rawClient, server, auth);
        CategoriesGroups = new CategoriesGroups(rawClient, server, auth);
        CategoriesUsers = new CategoriesUsers(rawClient, server, auth);
        CategoriesVideos = new CategoriesVideos(rawClient, server, auth);
        ChannelsCategories = new ChannelsCategories(rawClient, server, auth);
        ChannelsEssentials = new ChannelsEssentials(rawClient, server, auth);
        ChannelsModerators = new ChannelsModerators(rawClient, server, auth);
        ChannelsPrivateChannelMembers = new ChannelsPrivateChannelMembers(rawClient, server, auth);
        ChannelsSubscriptionsAndSubscribers = new ChannelsSubscriptionsAndSubscribers(rawClient, server, auth);
        ChannelsTags = new ChannelsTags(rawClient, server, auth);
        ChannelsVideos = new ChannelsVideos(rawClient, server, auth);
        EmbedPresetsCustomLogos = new EmbedPresetsCustomLogos(rawClient, server, auth);
        EmbedPresetsEssentials = new EmbedPresetsEssentials(rawClient, server, auth);
        EmbedPresetsFolders = new EmbedPresetsFolders(rawClient, server, auth);
        EmbedPresetsTimelineEvents = new EmbedPresetsTimelineEvents(rawClient, server, auth);
        EmbedPresetsVideos = new EmbedPresetsVideos(rawClient, server, auth);
        FoldersEssentials = new FoldersEssentials(rawClient, server, auth);
        FoldersItems = new FoldersItems(rawClient, server, auth);
        FoldersVideos = new FoldersVideos(rawClient, server, auth);
        GroupsEssentials = new GroupsEssentials(rawClient, server, auth);
        GroupsSubscriptions = new GroupsSubscriptions(rawClient, server, auth);
        GroupsUsers = new GroupsUsers(rawClient, server, auth);
        GroupsVideos = new GroupsVideos(rawClient, server, auth);
        LikesEssentials = new LikesEssentials(rawClient, server, auth);
        LiveAnalytics = new LiveAnalytics(rawClient, server, auth);
        LiveAudioTracks = new LiveAudioTracks(rawClient, server, auth);
        LiveEmbedPrivacy = new LiveEmbedPrivacy(rawClient, server, auth);
        LiveEssentials = new LiveEssentials(rawClient, server, auth);
        LiveEventM3U8Playback = new LiveEventM3U8Playback(rawClient, server, auth);
        LiveEventActivation = new LiveEventActivation(rawClient, server, auth);
        LiveEventAutomatedClosedCaptions = new LiveEventAutomatedClosedCaptions(rawClient, server, auth);
        LiveEventDestinations = new LiveEventDestinations(rawClient, server, auth);
        LiveEventEnd = new LiveEventEnd(rawClient, server, auth);
        LiveEventLowLatency = new LiveEventLowLatency(rawClient, server, auth);
        LiveEventSessions = new LiveEventSessions(rawClient, server, auth);
        LiveEventThumbnails = new LiveEventThumbnails(rawClient, server, auth);
        LiveEventVideos = new LiveEventVideos(rawClient, server, auth);
        LiveGraphics = new LiveGraphics(rawClient, server, auth);
        LiveScenes = new LiveScenes(rawClient, server, auth);
        OnDemandBackgrounds = new OnDemandBackgrounds(rawClient, server, auth);
        OnDemandEssentials = new OnDemandEssentials(rawClient, server, auth);
        OnDemandGenres = new OnDemandGenres(rawClient, server, auth);
        OnDemandPosters = new OnDemandPosters(rawClient, server, auth);
        OnDemandPromotions = new OnDemandPromotions(rawClient, server, auth);
        OnDemandPurchasesAndRentals = new OnDemandPurchasesAndRentals(rawClient, server, auth);
        OnDemandRegions = new OnDemandRegions(rawClient, server, auth);
        OnDemandSeasons = new OnDemandSeasons(rawClient, server, auth);
        OnDemandVideos = new OnDemandVideos(rawClient, server, auth);
        PaymentsEssentials = new PaymentsEssentials(rawClient, server, auth);
        PortfoliosEssentials = new PortfoliosEssentials(rawClient, server, auth);
        PortfoliosVideos = new PortfoliosVideos(rawClient, server, auth);
        SearchFederated = new SearchFederated(rawClient, server, auth);
        ShowcasesCustomShowcaseLogos = new ShowcasesCustomShowcaseLogos(rawClient, server, auth);
        ShowcasesCustomShowcaseThumbnails = new ShowcasesCustomShowcaseThumbnails(rawClient, server, auth);
        ShowcasesEssentials = new ShowcasesEssentials(rawClient, server, auth);
        ShowcasesShowcaseVideos = new ShowcasesShowcaseVideos(rawClient, server, auth);
        SubscriptionPlansEssentials = new SubscriptionPlansEssentials(rawClient, server, auth);
        TagsEssentials = new TagsEssentials(rawClient, server, auth);
        TeamsEssentials = new TeamsEssentials(rawClient, server, auth);
        TeamsMembers = new TeamsMembers(rawClient, server, auth);
        TutorialEssentials = new TutorialEssentials(rawClient, server, auth);
        UsersAnalytics = new UsersAnalytics(rawClient, server, auth);
        UsersEssentials = new UsersEssentials(rawClient, server, auth);
        UsersFeeds = new UsersFeeds(rawClient, server, auth);
        UsersFollowers = new UsersFollowers(rawClient, server, auth);
        UsersLms = new UsersLms(rawClient, server, auth);
        UsersPictures = new UsersPictures(rawClient, server, auth);
        UsersSearch = new UsersSearch(rawClient, server, auth);
        UsersWatchHistory = new UsersWatchHistory(rawClient, server, auth);
        VideosAi = new VideosAi(rawClient, server, auth);
        VideosAnimatedThumbnails = new VideosAnimatedThumbnails(rawClient, server, auth);
        VideosChapters = new VideosChapters(rawClient, server, auth);
        VideosContentRatings = new VideosContentRatings(rawClient, server, auth);
        VideosCreativeCommons = new VideosCreativeCommons(rawClient, server, auth);
        VideosCredits = new VideosCredits(rawClient, server, auth);
        VideosEmbedPrivacy = new VideosEmbedPrivacy(rawClient, server, auth);
        VideosEssentials = new VideosEssentials(rawClient, server, auth);
        VideosFragments = new VideosFragments(rawClient, server, auth);
        VideosLanguages = new VideosLanguages(rawClient, server, auth);
        VideosLiveM3U8Playback = new VideosLiveM3U8Playback(rawClient, server, auth);
        VideosModeration = new VideosModeration(rawClient, server, auth);
        VideosNondestructiveTrimming = new VideosNondestructiveTrimming(rawClient, server, auth);
        VideosRecommendations = new VideosRecommendations(rawClient, server, auth);
        VideosShowcases = new VideosShowcases(rawClient, server, auth);
        VideosTags = new VideosTags(rawClient, server, auth);
        VideosTextTracks = new VideosTextTracks(rawClient, server, auth);
        VideosThumbnails = new VideosThumbnails(rawClient, server, auth);
        VideosTranscripts = new VideosTranscripts(rawClient, server, auth);
        VideosUnlistedVideos = new VideosUnlistedVideos(rawClient, server, auth);
        VideosUploads = new VideosUploads(rawClient, server, auth);
        VideosVersions = new VideosVersions(rawClient, server, auth);
        VideosVideoComments = new VideosVideoComments(rawClient, server, auth);
        WatchLaterQueueEssentials = new WatchLaterQueueEssentials(rawClient, server, auth);
    }

    /// <summary>
    /// Use these methods to work with webhooks for API apps.
    /// </summary>
    public ApiAppsWebhooks ApiAppsWebhooks { get; }

    /// <summary>
    /// These are the most common methods for retrieving information about the Vimeo API.
    /// </summary>
    public ApiInformationEssentials ApiInformationEssentials { get; }

    /// <summary>
    /// Use these methods to perform authentication.
    /// </summary>
    public AuthenticationExtrasAuthenticate AuthenticationExtrasAuthenticate { get; }

    /// <summary>
    /// Use these methods to convert authentication resources.
    /// </summary>
    public AuthenticationExtrasConvert AuthenticationExtrasConvert { get; }

    /// <summary>
    /// These are the most common methods for working with authentication.
    /// </summary>
    public AuthenticationExtrasEssentials AuthenticationExtrasEssentials { get; }

    /// <summary>
    /// Use these methods to exchange authentication resources.
    /// </summary>
    public AuthenticationExtrasExchange AuthenticationExtrasExchange { get; }

    /// <summary>
    /// Use these methods to work with channels in a category.
    /// </summary>
    public CategoriesChannels CategoriesChannels { get; }

    /// <summary>
    /// These are the most common methods for working with categories.
    /// </summary>
    public CategoriesEssentials CategoriesEssentials { get; }

    /// <summary>
    /// Use these methods to work with groups in a category.
    /// </summary>
    public CategoriesGroups CategoriesGroups { get; }

    /// <summary>
    /// Use these methods to manage user interactions with a category.
    /// </summary>
    public CategoriesUsers CategoriesUsers { get; }

    /// <summary>
    /// Use these methods to work with videos in a category.
    /// </summary>
    public CategoriesVideos CategoriesVideos { get; }

    /// <summary>
    /// Use these methods to work with channel categories.
    /// </summary>
    public ChannelsCategories ChannelsCategories { get; }

    /// <summary>
    /// These are the most common methods for working with channels.
    /// </summary>
    public ChannelsEssentials ChannelsEssentials { get; }

    /// <summary>
    /// Use these methods to work with channel moderators.
    /// </summary>
    public ChannelsModerators ChannelsModerators { get; }

    /// <summary>
    /// Use these methods to work with private channel members.
    /// </summary>
    public ChannelsPrivateChannelMembers ChannelsPrivateChannelMembers { get; }

    /// <summary>
    /// Use these methods to work with channel subscriptions.
    /// </summary>
    public ChannelsSubscriptionsAndSubscribers ChannelsSubscriptionsAndSubscribers { get; }

    /// <summary>
    /// Use these methods to work with tags in channels.
    /// </summary>
    public ChannelsTags ChannelsTags { get; }

    /// <summary>
    /// Use these methods to work with videos in channels.
    /// </summary>
    public ChannelsVideos ChannelsVideos { get; }

    /// <summary>
    /// Vimeo members with access to embed presets can include their own logo images in the embedded player. These custom logos can be part of an embed preset.
    /// <para>
    ///             Use these methods to work with custom logos.
    /// </para>
    /// </summary>
    public EmbedPresetsCustomLogos EmbedPresetsCustomLogos { get; }

    /// <summary>
    /// These are the most common methods for working with embed presets.
    /// </summary>
    public EmbedPresetsEssentials EmbedPresetsEssentials { get; }

    /// <summary>
    /// Use these methods to work with folders that have embed presets.
    /// </summary>
    public EmbedPresetsFolders EmbedPresetsFolders { get; }

    /// <summary>
    /// Use these methods to work with timeline events.
    /// </summary>
    public EmbedPresetsTimelineEvents EmbedPresetsTimelineEvents { get; }

    /// <summary>
    /// Use these methods to work with videos that have embed presets.
    /// </summary>
    public EmbedPresetsVideos EmbedPresetsVideos { get; }

    /// <summary>
    /// These are the most common methods for working with folders.
    /// </summary>
    public FoldersEssentials FoldersEssentials { get; }

    /// <summary>
    /// Use these methods to manage items in folders.
    /// </summary>
    public FoldersItems FoldersItems { get; }

    /// <summary>
    /// Use these methods to manage videos in folders.
    /// </summary>
    public FoldersVideos FoldersVideos { get; }

    /// <summary>
    /// These are the most common methods for working with groups.
    /// </summary>
    public GroupsEssentials GroupsEssentials { get; }

    /// <summary>
    /// Use these methods to manage group membership.
    /// </summary>
    public GroupsSubscriptions GroupsSubscriptions { get; }

    /// <summary>
    /// Use these methods to manage group members.
    /// </summary>
    public GroupsUsers GroupsUsers { get; }

    /// <summary>
    /// Use these methods to manage group videos.
    /// </summary>
    public GroupsVideos GroupsVideos { get; }

    /// <summary>
    /// These are the most common methods for working with likes.
    /// </summary>
    public LikesEssentials LikesEssentials { get; }

    /// <summary>
    /// Use these methods to work with analytics for events.
    /// </summary>
    public LiveAnalytics LiveAnalytics { get; }

    /// <summary>
    /// Use these methods to work with event audio tracks.
    /// </summary>
    public LiveAudioTracks LiveAudioTracks { get; }

    /// <summary>
    /// Use these methods to work with embed privacy for events.
    /// </summary>
    public LiveEmbedPrivacy LiveEmbedPrivacy { get; }

    /// <summary>
    /// These are the most common methods for working with events.
    /// </summary>
    public LiveEssentials LiveEssentials { get; }

    /// <summary>
    /// Use these methods to work with M3U8 playback URLs for event streams.
    /// </summary>
    public LiveEventM3U8Playback LiveEventM3U8Playback { get; }

    /// <summary>
    /// Use these methods to work with the activation of events.
    /// </summary>
    public LiveEventActivation LiveEventActivation { get; }

    /// <summary>
    /// Use these methods to work with the automated closed captions preferences of events.
    /// </summary>
    public LiveEventAutomatedClosedCaptions LiveEventAutomatedClosedCaptions { get; }

    /// <summary>
    /// Use these methods to work with event destinations.
    /// </summary>
    public LiveEventDestinations LiveEventDestinations { get; }

    /// <summary>
    /// Use these methods to work with the ending of events.
    /// </summary>
    public LiveEventEnd LiveEventEnd { get; }

    /// <summary>
    /// Use these methods to manage an event's low-latency option.
    /// </summary>
    public LiveEventLowLatency LiveEventLowLatency { get; }

    /// <summary>
    /// Use these methods to work with event sessions.
    /// </summary>
    public LiveEventSessions LiveEventSessions { get; }

    /// <summary>
    /// Use these methods to work with the thumbnail images of events.
    /// </summary>
    public LiveEventThumbnails LiveEventThumbnails { get; }

    /// <summary>
    /// Use these methods to work with event videos.
    /// </summary>
    public LiveEventVideos LiveEventVideos { get; }

    /// <summary>
    /// Use these methods to work with event media.
    /// </summary>
    public LiveGraphics LiveGraphics { get; }

    /// <summary>
    /// Use these methods to work with event scenes.
    /// </summary>
    public LiveScenes LiveScenes { get; }

    /// <summary>
    /// Use these methods to work with background images on an On Demand page.
    /// </summary>
    public OnDemandBackgrounds OnDemandBackgrounds { get; }

    /// <summary>
    /// These are the most common methods for working with On Demand pages.
    /// </summary>
    public OnDemandEssentials OnDemandEssentials { get; }

    /// <summary>
    /// Use these methods to work with On Demand genres.
    /// </summary>
    public OnDemandGenres OnDemandGenres { get; }

    /// <summary>
    /// Use these methods to work with poster images on On Demand pages.
    /// </summary>
    public OnDemandPosters OnDemandPosters { get; }

    /// <summary>
    /// Use these methods to work with promotions on On Demand pages.
    /// </summary>
    public OnDemandPromotions OnDemandPromotions { get; }

    /// <summary>
    /// Use these methods to work with purchases and rentals on On Demand pages.
    /// </summary>
    public OnDemandPurchasesAndRentals OnDemandPurchasesAndRentals { get; }

    /// <summary>
    /// Use these methods to work with regions on On Demand pages.
    /// </summary>
    public OnDemandRegions OnDemandRegions { get; }

    /// <summary>
    /// Use these methods to work with On Demand seasons.
    /// </summary>
    public OnDemandSeasons OnDemandSeasons { get; }

    /// <summary>
    /// Use these methods to work with videos on On Demand pages.
    /// </summary>
    public OnDemandVideos OnDemandVideos { get; }

    /// <summary>
    /// These are the most common methods for making product purchases.
    /// </summary>
    public PaymentsEssentials PaymentsEssentials { get; }

    /// <summary>
    /// These are the most common methods for working with portfolios.
    /// </summary>
    public PortfoliosEssentials PortfoliosEssentials { get; }

    /// <summary>
    /// Use these methods to manage portfolio videos.
    /// </summary>
    public PortfoliosVideos PortfoliosVideos { get; }

    /// <summary>
    /// Use these methods to work with federated searches.
    /// </summary>
    public SearchFederated SearchFederated { get; }

    /// <summary>
    /// Use these methods to manage custom showcase logos, or the supplementary images, usually logos, that appear on a showcase's page. These images aren't the same as showcase thumbnails, or the images that represent the showcase across Vimeo.
    /// </summary>
    public ShowcasesCustomShowcaseLogos ShowcasesCustomShowcaseLogos { get; }

    /// <summary>
    /// Use these methods to manage custom thumbnail images for showcases. These thumbnails come from uploaded image files that aren't necessarily stills from a video.
    /// </summary>
    public ShowcasesCustomShowcaseThumbnails ShowcasesCustomShowcaseThumbnails { get; }

    /// <summary>
    /// These are the most common methods for working with showcases.
    /// </summary>
    public ShowcasesEssentials ShowcasesEssentials { get; }

    /// <summary>
    /// Use these methods to manage showcase videos.
    /// </summary>
    public ShowcasesShowcaseVideos ShowcasesShowcaseVideos { get; }

    /// <summary>
    /// These are the most common methods for working with subscription plans.
    /// </summary>
    public SubscriptionPlansEssentials SubscriptionPlansEssentials { get; }

    /// <summary>
    /// These are the most common methods for working with tags.
    /// </summary>
    public TagsEssentials TagsEssentials { get; }

    /// <summary>
    /// These are the most common methods for working with teams.
    /// </summary>
    public TeamsEssentials TeamsEssentials { get; }

    /// <summary>
    /// Use these methods to work with team members.
    /// </summary>
    public TeamsMembers TeamsMembers { get; }

    /// <summary>
    /// These are the most common methods for working with the API tutorial.
    /// </summary>
    public TutorialEssentials TutorialEssentials { get; }

    /// <summary>
    /// Use these methods to work with the authenticated user's video analytics.
    /// </summary>
    public UsersAnalytics UsersAnalytics { get; }

    /// <summary>
    /// These are the most common methods for working with users.
    /// </summary>
    public UsersEssentials UsersEssentials { get; }

    /// <summary>
    /// Use these methods to work with user feeds.
    /// </summary>
    public UsersFeeds UsersFeeds { get; }

    /// <summary>
    /// Use these methods to work with user followers.
    /// </summary>
    public UsersFollowers UsersFollowers { get; }

    /// <summary>
    /// Use these methods to work with learning management systems.
    /// </summary>
    public UsersLms UsersLms { get; }

    /// <summary>
    /// Use these methods to work with user pictures.
    /// </summary>
    public UsersPictures UsersPictures { get; }

    /// <summary>
    /// Use these methods to search for users.
    /// </summary>
    public UsersSearch UsersSearch { get; }

    /// <summary>
    /// Use these methods to work with a user's watch history.
    /// </summary>
    public UsersWatchHistory UsersWatchHistory { get; }

    /// <summary>
    /// Use these methods to access Vimeo's AI-powered video intelligence features, including automatic transcription, subtitle translation, audio dubbing, and video Q&amp;A. All endpoints require the <c>ai</c> OAuth scope and are available exclusively to Enterprise accounts. POST requests are subject to per-endpoint rate limits — contact your account team or Vimeo Sales to increase your allotment. Vimeo AI feature use is subject to <see href="https://vimeo.com/legal/service-terms/ai">Vimeo's AI Addendum</see>.
    /// </summary>
    public VideosAi VideosAi { get; }

    /// <summary>
    /// Use these methods to work with animated thumbnails for videos.
    /// </summary>
    public VideosAnimatedThumbnails VideosAnimatedThumbnails { get; }

    /// <summary>
    /// Use these methods to work with video chapters.
    /// </summary>
    public VideosChapters VideosChapters { get; }

    /// <summary>
    /// Use these methods to work with video content ratings.
    /// </summary>
    public VideosContentRatings VideosContentRatings { get; }

    /// <summary>
    /// Use these methods to work with Creative Commons licenses.
    /// </summary>
    public VideosCreativeCommons VideosCreativeCommons { get; }

    /// <summary>
    /// Use these methods to work with credited users in videos.
    /// </summary>
    public VideosCredits VideosCredits { get; }

    /// <summary>
    /// Use these methods to manage the allowlist of embeddable videos.
    /// </summary>
    public VideosEmbedPrivacy VideosEmbedPrivacy { get; }

    /// <summary>
    /// These are the most common methods for working with videos.
    /// </summary>
    public VideosEssentials VideosEssentials { get; }

    /// <summary>
    /// Use these methods to work with the video fragments for branched or segmented scrubbers.
    /// </summary>
    public VideosFragments VideosFragments { get; }

    /// <summary>
    /// Use these methods to work with video languages.
    /// </summary>
    public VideosLanguages VideosLanguages { get; }

    /// <summary>
    /// Use these methods to work with M3U8 playback URLs for event streams.
    /// </summary>
    public VideosLiveM3U8Playback VideosLiveM3U8Playback { get; }

    /// <summary>
    /// Use these methods to moderate videos.
    /// </summary>
    public VideosModeration VideosModeration { get; }

    /// <summary>
    /// Use these methods to work with nondestructive trimming.
    /// </summary>
    public VideosNondestructiveTrimming VideosNondestructiveTrimming { get; }

    /// <summary>
    /// Use these methods to work with recommended videos.
    /// </summary>
    public VideosRecommendations VideosRecommendations { get; }

    /// <summary>
    /// Use these methods to work with showcase videos.
    /// </summary>
    public VideosShowcases VideosShowcases { get; }

    /// <summary>
    /// Use these methods to work with associated tags.
    /// </summary>
    public VideosTags VideosTags { get; }

    /// <summary>
    /// Use these methods to work with video text tracks.
    /// </summary>
    public VideosTextTracks VideosTextTracks { get; }

    /// <summary>
    /// Use these methods to work with video thumbnails.
    /// </summary>
    public VideosThumbnails VideosThumbnails { get; }

    /// <summary>
    /// Use these methods to work with video transcripts.
    /// </summary>
    public VideosTranscripts VideosTranscripts { get; }

    /// <summary>
    /// Use these methods to work with unlisted videos.
    /// </summary>
    public VideosUnlistedVideos VideosUnlistedVideos { get; }

    /// <summary>
    /// Use these methods to work with video uploads.
    /// </summary>
    public VideosUploads VideosUploads { get; }

    /// <summary>
    /// Use these methods to work with video versioning.
    /// </summary>
    public VideosVersions VideosVersions { get; }

    /// <summary>
    /// Use these methods to work with video comments.
    /// </summary>
    public VideosVideoComments VideosVideoComments { get; }

    /// <summary>
    /// These are the most common methods for working with a user's Watch Later queue.
    /// </summary>
    public WatchLaterQueueEssentials WatchLaterQueueEssentials { get; }
}
